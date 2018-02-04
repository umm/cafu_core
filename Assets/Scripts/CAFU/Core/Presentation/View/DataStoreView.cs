using System.Collections.Generic;
using CAFU.Core.Data.Entity;
using UniRx;
using UnityEngine;
// ReSharper disable UnusedMember.Global

namespace CAFU.Core.Presentation.View {

    public interface IDataStoreView : IView, IObservableAwakeMonoBehaviour {

    }

    public interface IDataStoreViewResolver {

        [ObservableAwakeMonoBehaviour]
        IDataStoreView DataStoreView { get; }

    }

    public abstract class DataStoreView : ObservableLifecycleMonoBehaviour, IDataStoreView {

        [SerializeField]
        private List<IEntity> scriptableObjectEntityList;

        public List<IEntity> ScriptableObjectEntityList {
            get {
                return this.scriptableObjectEntityList;
            }
        }

    }

}