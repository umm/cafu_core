namespace CAFU.Core.Domain {

    public interface IUseCase {

    }

    public abstract class UseCaseBase<TUseCase> : IUseCase
        where TUseCase : UseCaseBase<TUseCase>, new() {

        protected virtual void Build() {
            // Do nothing.
        }

        public static TUseCase CreateInstance() {
            TUseCase instance = new TUseCase();
            instance.Build();
            return instance;
        }

    }

    public abstract class UseCaseBaseAsSingleton<TUseCase> : UseCaseBase<TUseCase>
        where TUseCase : UseCaseBaseAsSingleton<TUseCase>, new() {

        private static TUseCase instance;

        public static TUseCase GetOrCreateInstance() {
            if (instance == default(TUseCase)) {
                instance = new TUseCase();
                instance.Build();
            }
            return instance;
        }

    }

}