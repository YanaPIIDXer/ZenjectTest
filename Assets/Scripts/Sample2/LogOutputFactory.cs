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
            return LogOutput.Create("Dummy");
        }
    }

    /// <summary>
    /// Placeholder版
    /// </summary>
    public class LogOutputFactoryPlaceholder : PlaceholderFactory<LogOutput>
    {
        public LogOutput Create(string Message)
        {
            return LogOutput.Create(Message);
        }
    }
}
