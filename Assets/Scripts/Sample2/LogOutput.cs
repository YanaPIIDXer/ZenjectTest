using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Operators;
using UniRx.Triggers;
using System;

namespace Sample2
{
    /// <summary>
    /// LogOutputのインタフェース
    /// </summary>
    public interface ILogOutput
    {
        /// <summary>
        /// 破棄
        /// </summary>
        void Destroy();
    }

    /// <summary>
    /// ログを出力し続けるオブジェクト
    /// ファクトリメソッドから生成できる機能を持つ
    /// </summary>
    public class LogOutput : MonoBehaviour, ILogOutput
    {
        /// <summary>
        /// 生成
        /// </summary>
        /// <returns>LogOutputのComponent</returns>
        public static LogOutput Create()
        {
            GameObject Obj = new GameObject("LogOutput");
            return Obj.AddComponent<LogOutput>();
        }

        /// <summary>
        /// 破棄
        /// </summary>
        public void Destroy()
        {
            Destroy(gameObject);
        }

        void Awake()
        {
            this.UpdateAsObservable()
                .ThrottleFirst(TimeSpan.FromSeconds(1.0))
                .Subscribe((_) => Debug.Log("Log Output"))
                .AddTo(gameObject);
        }
    }
}
