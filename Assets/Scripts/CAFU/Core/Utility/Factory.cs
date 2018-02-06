namespace CAFU.Core.Utility {

    public interface ISingleton {

    }

    public class DefaultFactory<TFactory> where TFactory : DefaultFactory<TFactory>, new() {

        private static TFactory instance;

        public static TFactory Instance {
            get {
                if (instance == default(TFactory)) {
                    instance = new TFactory();
                }
                return instance;
            }
        }

    }

    public class DefaultFactory<TFactory, TTarget> : DefaultFactory<TFactory> where TFactory : DefaultFactory<TFactory, TTarget>, new() where TTarget : new() {

        private static TTarget targetInstance;

        private static TTarget TargetInstance {
            get {
                if (targetInstance == null) {
                    targetInstance = new TTarget();
                    Instance.Initialize(targetInstance);
                }
                return targetInstance;
            }
        }

        public TTarget Create() {
            if (typeof(ISingleton).IsAssignableFrom(typeof(TTarget))) {
                return TargetInstance;
            }
            TTarget target = new TTarget();
            this.Initialize(target);
            return target;
        }

        protected virtual void Initialize(TTarget instance) {
            // Do nothing.
        }

    }

}