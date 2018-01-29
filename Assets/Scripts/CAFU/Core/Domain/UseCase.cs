using System;
using System.Collections.Generic;
using CAFU.Core.Utility;

// ReSharper disable UnusedMember.Global

namespace CAFU.Core.Domain {

    public interface IUseCase {

    }

    public interface IUseCaseFactory<out TUseCase> where TUseCase : IUseCase {

        TUseCase Create();

    }

    public interface IUseCaseAsSingleton : IUseCase {

    }

    public class DefaultUseCaseFactory<TUseCase> : DefaultFactory<TUseCase>, IUseCaseFactory<TUseCase> where TUseCase : IUseCase, new() {

    }

    public class DefaultSingletonUseCaseFactory<TUseCase> : DefaultSingletonFactory<TUseCase>, IUseCaseFactory<TUseCase> where TUseCase : IUseCaseAsSingleton, new() {

    }

    [Obsolete("Please use IUseCaseFactory<TUseCase> instead of this interface.")]
    public interface IUseCaseBuilder {

        void Build();

    }

    [Obsolete("Please use DefaultUseCaseFactory, SingletonUseCaseFactory instead of this class.")]
    public static class UseCaseFactory {

        private static Dictionary<Type, IUseCase> instanceDictionary;

        // ReSharper disable once MemberCanBePrivate.Global
        public static TUseCase CreateInstance<TUseCase>() where TUseCase : class, IUseCase, new() {
            TUseCase instance = new TUseCase();
            // ReSharper disable once SuspiciousTypeConversion.Global
            IUseCaseBuilder builder = instance as IUseCaseBuilder;
            if (builder != default(IUseCaseBuilder)) {
                builder.Build();
            }
            return instance;
        }

        public static TUseCase GetOrCreateInstance<TUseCase>() where TUseCase : class, IUseCaseAsSingleton, new() {
            if (instanceDictionary == default(Dictionary<Type, IUseCase>)) {
                instanceDictionary = new Dictionary<Type, IUseCase>();
            }
            if (!instanceDictionary.ContainsKey(typeof(TUseCase))) {
                instanceDictionary[typeof(TUseCase)] = CreateInstance<TUseCase>();
            }
            return instanceDictionary[typeof(TUseCase)] as TUseCase;
        }

        public static void DestroyInstance<TUseCase>() where TUseCase : class, IUseCaseAsSingleton, new() {
            if (instanceDictionary == default(Dictionary<Type, IUseCase>)) {
                instanceDictionary = new Dictionary<Type, IUseCase>();
            }
            if (instanceDictionary.ContainsKey(typeof(TUseCase))) {
                instanceDictionary.Remove(typeof(TUseCase));
            }
        }

    }

}