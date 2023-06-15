// Copyright (c) 2023 - Gesma94
// This code is licensed under MIT license (see LICENSE for details)

using ExDependencyInjectionContainer.Models;

namespace ExDependencyInjectionContainer
{
    public class DiContainer
    {
        private readonly IList<RegisteredService> _registeredServiceCatalog = new List<RegisteredService>();

        public DiContainer AddSingleton<TInterface, TImplementation>() where TImplementation : TInterface
        {
            _registeredServiceCatalog.Add(new RegisteredService(typeof(TInterface), typeof(TImplementation), Enums.RegistrationType.Singleton));
            return this;
        }
    }
}