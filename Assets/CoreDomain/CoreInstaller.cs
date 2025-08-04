using UnityEngine;
using Zenject;

namespace IpegamaGames
{
    public class CoreInstaller : MonoInstaller
    {

        [SerializeField] private UpdateSubscriptionService _updateSubscriptionService;
        public override void InstallBindings()
        {
            Container.BindInterfacesTo<UnityLogger>().AsSingle().NonLazy();
            Container.BindInterfacesTo<UpdateSubscriptionService>().FromInstance(_updateSubscriptionService).AsSingle().NonLazy();
            //Container.BindInterfacesTo<AudioService>().FromInstance(_audioService).AsSingle().NonLazy();
        }
    }
}