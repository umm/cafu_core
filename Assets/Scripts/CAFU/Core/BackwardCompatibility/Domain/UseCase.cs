using System;
using System.Collections.Generic;
using System.Reflection;
using CAFU.Core.Domain.UseCase;

namespace CAFU.Core.Domain {

    [Obsolete("Please use IUseCase instead of this interface.")]
    public interface IUseCase : UseCase.IUseCase {

    }

    [Obsolete("Please use IUseCaseAsSingleton instead of this interface.")]
    public interface IUseCaseAsSingleton : UseCase.IUseCaseAsSingleton, IUseCase {

    }

    [Obsolete("Please use IUseCaseFactory<TUseCase> instead of this interface.")]
    public interface IUseCaseBuilder {

        void Build();

    }

    [Obsolete("Please use DefaultUseCaseFactory, SingletonUseCaseFactory instead of this class.")]
    public static class UseCaseFactory {

        private static Dictionary<Type, UseCase.IUseCase> instanceDictionary;

        // ReSharper disable once MemberCanBePrivate.Global
        public static TUseCase CreateInstance<TUseCase>() where TUseCase : class, UseCase.IUseCase, new() {
            Assembly assembly = Assembly.GetAssembly(typeof(TUseCase));
            Type factoryType = assembly.GetType($"{typeof(TUseCase).FullName}+Factory");
            if (factoryType != null) {
                return ((IUseCaseFactory<TUseCase>)Activator.CreateInstance(factoryType)).Create();
            }
            TUseCase instance = new TUseCase();
            // ReSharper disable once SuspiciousTypeConversion.Global
            IUseCaseBuilder builder = instance as IUseCaseBuilder;
            if (builder != default(IUseCaseBuilder)) {
                builder.Build();
            }
            return instance;
        }

        public static TUseCase GetOrCreateInstance<TUseCase>() where TUseCase : class, UseCase.IUseCaseAsSingleton, new() {
            if (instanceDictionary == default(Dictionary<Type, UseCase.IUseCase>)) {
                instanceDictionary = new Dictionary<Type, UseCase.IUseCase>();
            }
            if (!instanceDictionary.ContainsKey(typeof(TUseCase))) {
                instanceDictionary[typeof(TUseCase)] = CreateInstance<TUseCase>();
            }
            return instanceDictionary[typeof(TUseCase)] as TUseCase;
        }

        public static void DestroyInstance<TUseCase>() where TUseCase : class, UseCase.IUseCaseAsSingleton, new() {
            if (instanceDictionary == default(Dictionary<Type, UseCase.IUseCase>)) {
                instanceDictionary = new Dictionary<Type, UseCase.IUseCase>();
            }
            if (instanceDictionary.ContainsKey(typeof(TUseCase))) {
                instanceDictionary.Remove(typeof(TUseCase));
            }
        }

    }

}