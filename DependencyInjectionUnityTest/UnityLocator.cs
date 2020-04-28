using System;
using DependencyInjectionBuisness.Interfaces;
using Unity;

namespace DependencyInjectionUnityTest
{
    class UnityLocator : IUnityLocator
    {
        public T GetLocator<T>()
        {
            return Program.container.Resolve<T>();
        }
    }
}
