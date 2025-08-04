using Zenject;

namespace IpegamaGames
{
    public partial class CoreInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesTo<UnityLogger>().AsSingle().NonLazy();
            //Container.BindInterfacesTo<UpdateSubscriptionService>().FromInstance(_updateSubscriptionService).AsSingle().NonLazy();
            //Container.BindInterfacesTo<AudioService>().FromInstance(_audioService).AsSingle().NonLazy();
        }
    }
}