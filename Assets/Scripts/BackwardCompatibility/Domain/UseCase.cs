using System;
using System.Collections.Generic;
using CAFU.Core.Domain.UseCase;
using CAFU.Core.Utility;
#pragma warning disable 618

namespace CAFU.Core.Domain {

    [Obsolete("Please use IUseCase instead of this interface.")]
    public interface IUseCase : UseCase.IUseCase {

    }

    [Obsolete("Please use IUseCaseAsSingleton instead of this interface.")]
    public interface IUseCaseAsSingleton : ISingletonUseCase, IUseCase {

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
            return Factory.InvokeCreate<TUseCase>() ?? new UseCaseFactory<TUseCase>().Create();
        }

        public static TUseCase GetOrCreateInstance<TUseCase>() where TUseCase : class, ISingletonUseCase, new() {
            return Factory.InvokeCreate<TUseCase>() ?? new UseCaseFactory<TUseCase>().Create();
        }

        public static void DestroyInstance<TUseCase>() where TUseCase : class, ISingletonUseCase, new() {
            if (instanceDictionary == default(Dictionary<Type, UseCase.IUseCase>)) {
                instanceDictionary = new Dictionary<Type, UseCase.IUseCase>();
            }
            if (instanceDictionary.ContainsKey(typeof(TUseCase))) {
                instanceDictionary.Remove(typeof(TUseCase));
            }
        }

    }

    public class UseCaseFactory<TUseCase> : DefaultUseCaseFactory<TUseCase> where TUseCase : UseCase.IUseCase, new() {

        protected override void Initialize(TUseCase instance) {
            base.Initialize(instance);
            // ReSharper disable once SuspiciousTypeConversion.Global
            IUseCaseBuilder builder = instance as IUseCaseBuilder;
            if (builder != default(IUseCaseBuilder)) {
                builder.Build();
            }
        }

    }

}