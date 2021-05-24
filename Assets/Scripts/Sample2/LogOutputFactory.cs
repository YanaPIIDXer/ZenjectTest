using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Sample2
{
    /// <summary>
    /// LogOutputのファクトリ
    /// </summary>
    public class LogOutputFactory : IFactory<ILogOutput>
    {
        public ILogOutput Create()
        {
            return LogOutput.Create();
        }
    }

    /// <summary>
    /// ScriptableObject版
    /// </summary>
    public class LogOutputFactoryScriptable : ScriptableObject, IFactory<ILogOutput>
    {
        public ILogOutput Create()
        {
            return LogOutput.Create();
        }
    }
}
