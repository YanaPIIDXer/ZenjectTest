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
            /*
            Container.Bind<ILogOutput>()
                     .FromIFactory(x => x.To<LogOutputFactory>().FromNew().AsTransient());
            */

            Container.BindFactory<LogOutput, LogOutputFactoryPlaceholder>()
                     .FromIFactory(x => x.To<LogOutputFactoryPlaceholder>().FromNew().AsTransient());

            // 下記の記述でPureClassにInjectできるようになる
            Container.Bind<PureClass>().AsTransient();

            // Singletonの場合
            // ただ、良くないやり方らしい（bad practiceと言うWarningが出る）
            // 結論：SingletonへのInjectも強引にやろうと思えばできる
            Container.Bind<PureSingleton>().AsCached();
            Container.Resolve<PureSingleton>();
        }
    }
}
