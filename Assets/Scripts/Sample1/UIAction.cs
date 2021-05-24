using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
using UniRx;
using System;

namespace Sample1
{
    /// <summary>
    /// UIの入力によってアクションを起こすクラス
    /// </summary>
    public class UIAction : MonoBehaviour
    {
        /// <summary>
        /// 入力UI
        /// </summary>
        [Inject]
        private IMainUI InputUI = null;

        void Awake()
        {
            InputUI.OnPressedAButton
                .Subscribe((_) => Debug.Log("A"));
            InputUI.OnPressedBButton
                .Subscribe((_) => Debug.Log("B"));
        }
    }
}
