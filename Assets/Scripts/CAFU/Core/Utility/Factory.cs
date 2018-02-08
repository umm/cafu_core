// ReSharper disable UnusedMember.Global

using UnityEngine;
// ReSharper disable VirtualMemberNeverOverridden.Global

namespace CAFU.Core.Utility {

    public interface ISingleton {

    }

    public interface IFactory {

    }

    public interface IFactory<out TTarget> : IFactory {

        TTarget Create();

    }

    // 本当は Factory クラス自体を Singleton にしたいが、AOT の制約により Generics 型の Factory が落とされてしまうため断念
    public abstract class Factory<TTarget> : IFactory<TTarget> {

        private static TTarget TargetInstance { get; set; }

        public virtual TTarget Create() {
            if (typeof(ISingleton).IsAssignableFrom(typeof(TTarget))) {
                if (TargetInstance == null) {
                    TargetInstance = this.ConstructInstance();
                    this.Initialize(TargetInstance);
                }
                return TargetInstance;
            }
            TTarget target = this.ConstructInstance();
            this.Initialize(target);
            return target;
        }

        public virtual void Destroy() {
            if (typeof(ISingleton).IsAssignableFrom(typeof(TTarget))) {
                TargetInstance = default(TTarget);
            }
        }

        protected virtual void Initialize(TTarget instance) {
            // Do nothing.
        }

        protected abstract TTarget ConstructInstance();

    }

    public class SceneFactory<TTarget> : Factory<TTarget> where TTarget : Object {

        protected override TTarget ConstructInstance() {
            return Object.FindObjectOfType<TTarget>();
        }

    }

    public class DefaultFactory<TTarget> : Factory<TTarget> where TTarget : new() {

        protected override TTarget ConstructInstance() {
            return new TTarget();
        }

    }

}