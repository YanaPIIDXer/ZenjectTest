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
        /// <param name="Message">表示する文字列</param>
        /// <returns>LogOutputのComponent</returns>
        public static LogOutput Create(string Message)
        {
            GameObject Obj = new GameObject("LogOutput");
            var Output = Obj.AddComponent<LogOutput>();
            Output.Message = Message;
            return Output;
        }

        /// <summary>
        /// 表示する文字列
        /// </summary>
        private string Message = "Log Output";

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
                .Subscribe((_) => Debug.Log(Message))
                .AddTo(gameObject);
        }
    }
}
