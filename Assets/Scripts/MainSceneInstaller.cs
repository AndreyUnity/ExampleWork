using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class MainSceneInstaller : MonoInstaller<MainSceneInstaller>
{
    [SerializeField]
    private OrbitCameraObserver orbitCamera;

    public override void InstallBindings()
    {
        Container.Bind<IOrbitCameraObserverInput>().FromInstance(orbitCamera);
#if UNITY_EDITOR || UNITY_STANDALONE_WIN
        Container.Bind<IOrbitObserverInput>().To<StandaloneOrbitObserverInput>().AsSingle();
#elif UNITY_ANDROID
        Container.Bind<IOrbitObserverInput>().To<MobileOrbitObserverInput>().AsSingle();
#endif
    }

}
