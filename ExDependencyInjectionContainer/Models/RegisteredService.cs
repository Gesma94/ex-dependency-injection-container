// Copyright (c) 2023 - Gesma94
// This code is licensed under MIT license (see LICENSE for details)

using ExDependencyInjectionContainer.Enums;

namespace ExDependencyInjectionContainer.Models
{
    internal record RegisteredService(Type InterfaceType, Type ImplementationType, RegistrationType RegistrationType);
}
