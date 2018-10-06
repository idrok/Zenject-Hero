﻿using Zenject;

namespace Code.LightSwitcher
{
    public class LightsOffSignalInstaller : MonoInstaller<LightsOffSignalInstaller>
    {
        public override void InstallBindings()
        {
            Container.DeclareSignal<LightsOffSignal>();

            Container.BindSignal<LightsOffSignal>()
                .ToMethod<LightSwitcher>(x => x.TurnOffLightInCurrentScreen)
                .FromResolve();
        }
    }
}