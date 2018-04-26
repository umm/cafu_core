using System;
using System.Linq;
using System.Reflection;

namespace CAFU.Core.Utility {

    public class Factory {

        public static T InvokeCreate<T>() where T : class {
            Assembly assembly = Assembly.GetAssembly(typeof(T));
            Type factoryType = assembly.GetType(string.Format("{0}+Factory", typeof(T).FullName));
            if (factoryType == null) {
                return null;
            }
            object factoryInstance = factoryType.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.FlattenHierarchy).First(x => x.Name == "Instance").GetValue(factoryType, null);
            MethodInfo methodInfo = factoryType.GetMethod("Create", BindingFlags.Public | BindingFlags.Instance | BindingFlags.FlattenHierarchy);
            if (methodInfo == null) {
                return null;
            }
            return (T)methodInfo.Invoke(factoryInstance, null);
        }

    }

}