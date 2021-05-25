using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sample2
{
    /// <summary>
    /// Pureなクラスのインスタンスを保持するMonoBehaviour派生クラス
    /// </summary>
    public class PureClassOwningComponent : MonoBehaviour
    {
        /// <summary>
        /// Pureなクラスのインスタンス
        /// </summary>
        private PureClass PureInstance = new PureClass();
    }
}
