using UnityEngine;
using Zenject;

namespace Sample1
{
    public class MonoErrorLoggerInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container
                .Bind<IErrorLogger>()
                .To<ErrorLogger>()
                .AsCached();
        }
    }
}
