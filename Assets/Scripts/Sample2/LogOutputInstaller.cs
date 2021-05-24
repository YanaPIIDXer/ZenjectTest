using UnityEngine;
using Zenject;

namespace Sample2
{
    public class LogOutputInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            /*
            Container.Bind<ILogOutput>()
                     .FromIFactory(x => x.To<LogOutputFactory>().AsCached());
            */
            Container.Bind<ILogOutput>()
                     .FromIFactory(x => x.To<LogOutputFactoryScriptable>().FromNewScriptableObject(new LogOutputFactoryScriptable()).AsCached());
        }
    }
}
