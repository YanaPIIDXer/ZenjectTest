using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

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
        [Inject]
        private PureClass PureInstance = null;

        void Awake()
        {
            if (PureInstance.LogOutputIsValid)
            {
                Debug.Log("PureInstance have valid LogOutput.");
            }
            else
            {
                Debug.LogError("PureInstance don't have valid LogOutput.");
            }

            if (PureSingleton.Insatnce != null)
            {
                Debug.Log("PureSingleton Instantiated.");
                if (PureSingleton.Insatnce.LogOutputIsValid)
                {
                    Debug.Log("PureSingleton have valid LogOutput.");
                }
                else
                {
                    Debug.LogError("PureSingleton don't have valid LogOutput.");
                }

            }
            else
            {
                Debug.LogError("PureSingleton is null.");
            }
        }
    }
}
