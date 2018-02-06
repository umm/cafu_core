// ReSharper disable UnusedMember.Global
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
            set {
                targetInstance = value;
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

        public void Destroy() {
            if (typeof(ISingleton).IsAssignableFrom(typeof(TTarget))) {
                TargetInstance = default(TTarget);
            }
        }

        protected virtual void Initialize(TTarget instance) {
            // Do nothing.
        }

    }

}