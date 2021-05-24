using UnityEngine;
using Zenject;

namespace Sample1
{
    class OutputFactory : PlaceholderFactory<LogOutput> { }

    public class MonoLoggerInstaller : MonoInstaller
    {
        [SerializeField]
        private GameObject OutputPrefab = null;

        public override void InstallBindings()
        {
            Container
                .Bind<ILogger>()
                .To<BasicLogger>()
                .AsCached();

            Container
                .BindFactory<LogOutput, OutputFactory>()
                .FromComponentInNewPrefab(OutputPrefab);
        }
    }
}
