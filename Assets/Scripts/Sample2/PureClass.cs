using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sample2
{
    /// <summary>
    /// MonoBehaviourを継承しないクラス
    /// </summary>
    public class PureClass
    {
    }

    /// <summary>
    /// MonoBehaviourを派生しないSingletonなクラス
    /// </summary>
    public class PureSingleton
    {
        #region Singleton
        public static PureSingleton Insatnce { get { return _Instance; } }
        private static PureSingleton _Instance = new PureSingleton();
        private PureSingleton() { }
        #endregion
    }
}
