using System;
using System.Collections.Generic;

namespace CAFU.Core.Domain {

    public interface IUseCase {

    }

    public interface IUseCaseBuilder {

        void Build();

    }

    public static class UseCaseBuilder {

        private static Dictionary<Type, IUseCase> instanceDictionary;

        public static TUseCase CreateInstance<TUseCase>() where TUseCase : class, IUseCase, new() {
            TUseCase instance = new TUseCase();
            IUseCaseBuilder builder = instance as IUseCaseBuilder;
            if (builder != default(IUseCaseBuilder)) {
                builder.Build();
            }
            return instance;
        }

        public static TUseCase GetOrCreateInstance<TUseCase>() where TUseCase : class, IUseCase, new() {
            if (instanceDictionary == default(Dictionary<Type, IUseCase>)) {
                instanceDictionary = new Dictionary<Type, IUseCase>();
            }
            if (!instanceDictionary.ContainsKey(typeof(TUseCase))) {
                instanceDictionary[typeof(TUseCase)] = CreateInstance<TUseCase>();
            }
            return instanceDictionary[typeof(TUseCase)] as TUseCase;
        }

    }

}