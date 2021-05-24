using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
using UniRx;
using UniRx.Operators;
using UniRx.Triggers;
using System;

namespace Sample2
{
    /// <summary>
    /// LogOutputを生成して一定時間後に消すオブジェクト
    /// </summary>
    public class LogOutputSpawner : MonoBehaviour
    {
        /// <summary>
        /// Factory
        /// </summary>
        [Inject]
        private LogOutputFactoryPlaceholder OutputFactory = null;

        void Awake()
        {
            ILogOutput Output = OutputFactory.Create();
            this.UpdateAsObservable()
                .ThrottleFirst(TimeSpan.FromSeconds(5.0))
                .Skip(1)
                .Take(1)
                .Subscribe((_) => Output.Destroy())
                .AddTo(gameObject);
        }
    }
}
