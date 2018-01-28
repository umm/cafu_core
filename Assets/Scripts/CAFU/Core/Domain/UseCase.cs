using System;
using System.Collections.Generic;
// ReSharper disable UnusedMember.Global

namespace CAFU.Core.Domain {

    public interface IUseCase {

    }

    public interface IUseCaseFactory<out TUseCase> where TUseCase : IUseCase {

        TUseCase Create();

    }

    public interface IUseCaseAsSingleton : IUseCase {

    }

    public class DefaultUseCaseFactory<TUseCase> : IUseCaseFactory<TUseCase> where TUseCase : IUseCase, new() {

        public TUseCase Create() {
            return new TUseCase();
        }

    }

    public class SingletonUseCaseFactory<TUseCase> : IUseCaseFactory<TUseCase> where TUseCase : IUseCaseAsSingleton, new() {

        private static TUseCase instance;

        private static TUseCase Instance {
            get {
                if (instance == null) {
                    instance = new TUseCase();
                }
                return instance;
            }
        }

        public TUseCase Create() {
            return Instance;
        }

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