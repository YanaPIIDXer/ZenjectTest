using UnityEngine;
using Zenject;

public class MonoLoggerInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container
            .Bind<ILogger>()
            .To<BasicLogger>()
            .AsCached();
    }
}