using UnityEngine;
using Zenject;

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