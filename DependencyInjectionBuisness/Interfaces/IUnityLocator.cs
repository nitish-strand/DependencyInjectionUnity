using System;

namespace DependencyInjectionBuisness.Interfaces
{
    public interface IUnityLocator
    {
        T GetLocator<T>();
    }
}
