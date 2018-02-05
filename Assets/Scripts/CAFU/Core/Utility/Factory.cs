namespace CAFU.Core.Utility {

    public interface ISingleton {

    }

    public class DefaultFactory<T> where T : new() {

        private static T instance;

        private static T Instance {
            get {
                if (instance == null) {
                    instance = new T();
                }
                return instance;
            }
        }

        public virtual T Create() {
            if (typeof(ISingleton).IsAssignableFrom(typeof(T))) {
                return Instance;
            }
            return new T();
        }

    }

}