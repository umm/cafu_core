namespace CAFU.Core.Utility {

    public class DefaultFactory<T> where T : new() {

        public T Create() {
            return new T();
        }

    }

    public class DefaultSingletonFactory<T> where T : new() {

        private static T instance;

        private static T Instance {
            get {
                if (instance == null) {
                    instance = new T();
                }
                return instance;
            }
        }

        public T Create() {
            return Instance;
        }

    }

}