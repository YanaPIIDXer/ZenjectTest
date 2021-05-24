using UnityEngine;
using Zenject;

namespace Sample1
{
    public class MainUIInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container
                .Bind<IMainUI>()
                .To<MainUI>()
                .FromComponentInHierarchy()     // MonoBehaviour継承クラスの場合はこれが必要
                .AsCached();
        }
    }
}
