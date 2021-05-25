using UnityEngine;
using Zenject;

namespace Sample2
{
    public class LogOutputInstaller : MonoInstaller
    {
        public override void Start()
        {
            base.Start();

            // 下記の記述でPureClassにInjectできるようになる
            // 但し、InjectされるのはMonoBehaviourのAwakeやStartライフサイクルの後になるので注意が必要
            Container.Bind<PureClass>().AsSingle();
            Container.Resolve<PureClass>();
        }

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
        }
    }
}
