namespace CAFU.Core.Domain {

    public interface IUseCase {

    }

    public interface IUseCaseBuilder {

        void Build();

    }

    public abstract class UseCaseBase<TUseCase> : IUseCase
        where TUseCase : UseCaseBase<TUseCase>, new() {

        public static TUseCase CreateInstance() {
            TUseCase instance = new TUseCase();
            IUseCaseBuilder builder = instance as IUseCaseBuilder;
            if (builder != default(IUseCaseBuilder)) {
                builder.Build();
            }
            return instance;
        }

    }

    public abstract class UseCaseBaseAsSingleton<TUseCase> : UseCaseBase<TUseCase>
        where TUseCase : UseCaseBaseAsSingleton<TUseCase>, new() {

        private static TUseCase instance;

        public static TUseCase GetOrCreateInstance() {
            if (instance == default(TUseCase)) {
                instance = CreateInstance();
            }
            return instance;
        }

    }

}