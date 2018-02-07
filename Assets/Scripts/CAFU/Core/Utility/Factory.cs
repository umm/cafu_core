// ReSharper disable UnusedMember.Global
namespace CAFU.Core.Utility {

    public interface ISingleton {

    }

//    public class DefaultFactory<TFactory> where TFactory : DefaultFactory<TFactory>, new() {
//
//        private static TFactory instance;
//
//        public static TFactory Instance {
//            get {
//                if (instance == default(TFactory)) {
//                    instance = new TFactory();
//                }
//                return instance;
//            }
//        }
//
//    }

    public interface IFactory {

    }

    public interface IFactory<out TTarget> : IFactory {

        TTarget Create();

    }

    public class SingletonFactory<TFactory> : IFactory where TFactory : SingletonFactory<TFactory>, new() {

        // Initialize メソッドで同名の引数を用いるためフィールド側を変更しています
        private static TFactory factoryInstance;

        public static TFactory Instance {
            get {
                if (factoryInstance == default(TFactory)) {
                    factoryInstance = new TFactory();
                }
                return factoryInstance;
            }
        }

    }

    public class DefaultFactory<TFactory, TTarget> : SingletonFactory<TFactory>, IFactory<TTarget> where TFactory : DefaultFactory<TFactory, TTarget>, new() where TTarget : new() {

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