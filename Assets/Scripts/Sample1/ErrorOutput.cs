using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
using UniRx;
using System;

namespace Sample1
{
    /// <summary>
    /// エラー出力
    /// </summary>
    public class ErrorOutput : MonoBehaviour
    {
        [Inject]
        private void Setup(IErrorLogger Logger)
        {
            Observable.Interval(TimeSpan.FromSeconds(3.0))
                .Subscribe((_) => Logger.Show("Test"));
        }
    }
}
