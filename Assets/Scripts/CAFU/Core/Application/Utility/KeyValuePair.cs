using UnityEngine;

namespace CAFU.Core.Application.Utility {

    public interface IKeyValuePair<TKey, TValue> {

        TKey Key { get; set; }

        TValue Value { get; set; }

    }

    public class KeyValuePair<TKey, TValue> : IKeyValuePair<TKey, TValue> {

        [SerializeField]
        private TKey key;

        public TKey Key {
            get {
                return this.key;
            }
            set {
                this.key = value;
            }
        }

        [SerializeField]
        private TValue value;

        public TValue Value {
            get {
                return this.value;
            }
            set {
                this.value = value;
            }
        }

        public KeyValuePair() {
        }

        public KeyValuePair(TKey key, TValue value) {
            this.Key = key;
            this.Value = value;
        }

    }

}