using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Sample2
{
    /// <summary>
    /// MonoBehaviourを継承しないクラス
    /// </summary>
    public class PureClass
    {
        /// <summary>
        /// LogOutputインタフェース
        /// </summary>
        private ILogOutput Output = null;

        /// <summary>
        /// 有効なLogOutputを保持しているか？
        /// </summary>
        public bool LogOutputIsValid { get { return Output != null; } }

        /// <summary>
        /// 注入
        /// </summary>
        /// <param name="Factory">LogOutputファクトリ</param>
        [Inject]
        public void Inject(LogOutputFactoryPlaceholder Factory)
        {
            Output = Factory.Create("PureClass");
        }
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
