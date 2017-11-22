using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace CAFU.Core.Domain {

    /// <summary>
    /// Model インタフェース
    /// </summary>
    public interface IModel {

    }

    /// <summary>
    /// 配列型の Model インタフェース
    /// </summary>
    /// <remarks>IList であるコトを宣言するだけなので、原則的には interface の継承にのみ用いる</remarks>
    public interface IListModel : IModel, IList {

    }

    /// <summary>
    /// 配列型の Model インタフェース
    /// </summary>
    /// <remarks>実装クラス側で実装することで Model を List 的に参照出来るようにする</remarks>
    /// <typeparam name="TModel">要素の型</typeparam>
    public interface IListModel<TModel> : IModel, IList<TModel>
        where TModel : IModel {

        List<TModel> List { get; }

    }

    /// <summary>
    /// 辞書型の Model インタフェース
    /// </summary>
    /// <remarks>IDictionary であるコトを宣言するだけなので、原則的には interface の継承にのみ用いる</remarks>
    public interface IMapModel : IModel, IDictionary {

    }

    /// <summary>
    /// 辞書型の Model インタフェース
    /// </summary>
    /// <remarks>実装クラス側で実装することで Model を Dictionary 的に参照出来るようにする</remarks>
    /// <typeparam name="TKey">辞書のキーの型</typeparam>
    /// <typeparam name="TValue">辞書の値の型</typeparam>
    /// <typeparam name="TKeyValuePair">辞書の KeyValuePair の型</typeparam>
    public interface IMapModel<TKey, TValue, TKeyValuePair> : IModel, IDictionary<TKey, TValue>
        where TValue : IModel
        where TKeyValuePair : Core.Application.Utility.IKeyValuePair<TKey, TValue> {

        List<TKeyValuePair> Map { get; }

    }

    /// <summary>
    /// Model 基底クラス
    /// </summary>
    public abstract class ModelBase : IModel {

    }

    /// <summary>
    /// 配列型の Model 基底クラス
    /// </summary>
    /// <typeparam name="TModel">要素の型</typeparam>
    public abstract class ListModelBase<TModel> : IListModel<TModel>, IListModel where TModel : IModel {

        [SerializeField]
        private List<TModel> list;

        public List<TModel> List {
            get {
                if (this.list == default(List<TModel>)) {
                    this.list = new List<TModel>();
                }
                return this.list;
            }
        }

        int ICollection.Count {
            get {
                return this.List.Count;
            }
        }

        int ICollection<TModel>.Count {
            get {
                return this.List.Count;
            }
        }

        public bool IsFixedSize {
            get {
                return this.List.ToArray().IsFixedSize;
            }
        }

        bool IList.IsReadOnly {
            get {
                return this.List.ToArray().IsReadOnly;
            }
        }

        public bool IsSynchronized {
            get {
                return this.List.ToArray().IsSynchronized;
            }
        }

        bool ICollection<TModel>.IsReadOnly {
            get {
                return this.List.ToArray().IsReadOnly;
            }
        }

        public object SyncRoot {
            get {
                return this.List.ToArray().SyncRoot;
            }
        }

        public IEnumerator<TModel> GetEnumerator() {
            return this.List.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }

        public void Add(TModel item) {
            this.List.Add(item);
        }

        public int Add(object value) {
            this.List.Add((TModel)value);
            return this.List.IndexOf((TModel)value);
        }

        void IList.Clear() {
            this.List.Clear();
        }

        void ICollection<TModel>.Clear() {
            this.List.Clear();
        }

        public bool Contains(object value) {
            return this.List.Contains((TModel)value);
        }

        public bool Contains(TModel item) {
            return this.List.Contains(item);
        }

        public void CopyTo(Array array, int index) {
            this.List.CopyTo((TModel[])array, index);
        }

        public void CopyTo(TModel[] array, int arrayIndex) {
            this.List.CopyTo(array, arrayIndex);
        }

        public int IndexOf(object value) {
            return this.List.IndexOf((TModel)value);
        }

        public int IndexOf(TModel item) {
            return this.List.IndexOf(item);
        }

        public void Insert(int index, object value) {
            this.List.Insert(index, (TModel)value);
        }

        public void Insert(int index, TModel item) {
            this.List.Insert(index, item);
        }

        public void Remove(object value) {
            this.List.Remove((TModel)value);
        }

        public bool Remove(TModel item) {
            return this.List.Remove(item);
        }

        void IList.RemoveAt(int index) {
            this.List.RemoveAt(index);
        }

        void IList<TModel>.RemoveAt(int index) {
            this.List.RemoveAt(index);
        }

        object IList.this[int index] {
            get {
                return this.List[index];
            }
            set {
                this.List[index] = (TModel)value;
            }
        }

        public TModel this[int index] {
            get {
                return this.List[index];
            }
            set {
                this.List[index] = value;
            }
        }

    }

    /// <summary>
    /// 辞書型の Model 基底クラス
    /// </summary>
    /// <remarks>シリアライズが不要な場合はコチラを用いる</remarks>
    /// <typeparam name="TKey">辞書のキーの型</typeparam>
    /// <typeparam name="TValue">辞書の値の型</typeparam>
    public abstract class MapModelBase<TKey, TValue> : MapModelBase<TKey, TValue, Core.Application.Utility.KeyValuePair<TKey, TValue>>
        where TValue : IModel {

    }

    /// <summary>
    /// 辞書型の Model 基底クラス
    /// </summary>
    /// <remarks>シリアライズが必要な場合はコチラを用いる</remarks>
    /// <remarks>Unity のシリアライザの仕様上、Serializable な KeyValuePair 型を宣言する必要がある</remarks>
    /// <typeparam name="TKey">辞書のキーの型</typeparam>
    /// <typeparam name="TValue">辞書の値の型</typeparam>
    /// <typeparam name="TKeyValuePair">辞書の KeyValuePair の型</typeparam>
    public abstract class MapModelBase<TKey, TValue, TKeyValuePair> : IMapModel<TKey, TValue, TKeyValuePair>, IMapModel
        where TValue : IModel
        where TKeyValuePair : class, Core.Application.Utility.IKeyValuePair<TKey, TValue>, new() {

        [SerializeField]
        private List<TKeyValuePair> map;

        public List<TKeyValuePair> Map {
            get {
                if (this.map == default(List<TKeyValuePair>)) {
                    this.map = new List<TKeyValuePair>();
                }
                return this.map;
            }
        }

        int ICollection.Count {
            get {
                return this.Map.Count;
            }
        }

        public bool IsSynchronized {
            get {
                return this.Map.ToArray().IsSynchronized;
            }
        }

        public object SyncRoot {
            get {
                return this.Map.ToArray().SyncRoot;
            }
        }

        int ICollection<KeyValuePair<TKey, TValue>>.Count {
            get {
                return this.Map.Count;
            }
        }

        bool ICollection<KeyValuePair<TKey, TValue>>.IsReadOnly {
            get {
                return this.Map.ToArray().IsReadOnly;
            }
        }

        public bool IsFixedSize {
            get {
                return this.Map.ToArray().IsFixedSize;
            }
        }

        bool IDictionary.IsReadOnly {
            get {
                return this.Map.ToArray().IsReadOnly;
            }
        }

        ICollection IDictionary.Keys {
            get {
                return this.Map.Select(x => x.Key).ToList();
            }
        }

        ICollection<TKey> IDictionary<TKey, TValue>.Keys {
            get {
                return this.Map.Select(x => x.Key).ToList();
            }
        }

        ICollection IDictionary.Values {
            get {
                return this.Map.Select(x => x.Value).ToList();
            }
        }

        ICollection<TValue> IDictionary<TKey, TValue>.Values {
            get {
                return this.Map.Select(x => x.Value).ToList();
            }
        }

        object IDictionary.this[object key] {
            get {
                return this.Map.Find(x => Equals(x.Key, key)).Value;
            }
            set {
                this.Map.Find(x => Equals(x.Key, key)).Value = (TValue)value;
            }
        }

        TValue IDictionary<TKey, TValue>.this[TKey key] {
            get {
                return this.Map.Find(x => Equals(x.Key, key)).Value;
            }
            set {
                this.Map.Find(x => Equals(x.Key, key)).Value = value;
            }
        }

        public void Add(object key, object value) {
            this.Map.Add(new TKeyValuePair() { Key = (TKey)key, Value = (TValue)value, });
        }

        public void Add(KeyValuePair<TKey, TValue> item) {
            this.Map.Add(new TKeyValuePair() { Key = item.Key, Value = item.Value, });
        }

        public void Add(TKey key, TValue value) {
            this.Map.Add(new TKeyValuePair() { Key = key, Value = value, });
        }

        void IDictionary.Clear() {
            this.Map.Clear();
        }

        void ICollection<KeyValuePair<TKey, TValue>>.Clear() {
            this.Map.Clear();
        }

        public bool Contains(object key) {
            return this.Map.Contains(this.Map.Find(x => Equals(x.Key, key)));
        }

        public bool Contains(KeyValuePair<TKey, TValue> item) {
            return this.Map.Any(x => Equals(x.Key, item.Key) && Equals(x.Value, item.Value));
        }

        public bool ContainsKey(TKey key) {
            return this.Map.Any(x => Equals(x.Key, key));
        }

        public void CopyTo(Array array, int index) {
            this.Map.CopyTo(((KeyValuePair<TKey, TValue>[])array).Select(x => new TKeyValuePair() { Key = x.Key, Value = x.Value, }).ToArray(), index);
        }

        public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex) {
            this.Map.CopyTo(array.Select(x => new TKeyValuePair() { Key = x.Key, Value = x.Value, }).ToArray(), arrayIndex);
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return this.Map.Select(x => new KeyValuePair<TKey, TValue>(x.Key, x.Value)).GetEnumerator();
        }

        IDictionaryEnumerator IDictionary.GetEnumerator() {
            return this.Map.ToDictionary(x => x.Key, x => x.Value).GetEnumerator();
        }

        IEnumerator<KeyValuePair<TKey, TValue>> IEnumerable<KeyValuePair<TKey, TValue>>.GetEnumerator() {
            return this.Map.Select(x => new KeyValuePair<TKey, TValue>(x.Key, x.Value)).GetEnumerator();
        }

        public void Remove(object key) {
            this.Map.Remove(this.Map.Find(x => Equals(x.Key, key)));
        }

        public bool Remove(KeyValuePair<TKey, TValue> item) {
            return this.Map.Remove(this.Map.Find(x => Equals(x.Key, item.Key) && Equals(x.Value, item.Value)));
        }

        public bool Remove(TKey key) {
            return this.Map.Remove(this.Map.Find(x => Equals(x.Key, key)));
        }

        public bool TryGetValue(TKey key, out TValue value) {
            if (this.ContainsKey(key)) {
                value = this.Map.Find(x => Equals(x.Key, key)).Value;
                return true;
            }
            value = default(TValue);
            return false;
        }

    }

}