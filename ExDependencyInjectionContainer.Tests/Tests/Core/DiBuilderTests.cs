// Copyright (c) 2023 - Gesma94
// This code is licensed under MIT license (see LICENSE for details)

using ExDependencyInjectionContainer.Core;
using ExDependencyInjectionContainer.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExDependencyInjectionContainer.Tests.Sources.Services;
using ExDependencyInjectionContainer.Tests.Sources.Interfaces;

namespace ExDependencyInjectionContainer.Tests.Tests.Core
{
    [TestClass]
    public class DiBuilderTests
    {
        [TestClass]
        public class AddSingletonTests
        {
            [TestMethod]
            public void AddSingletonService()
            {
                var diBuilder = new DiBuilder()
                    .AddSingleton<IFooService, FooServiceImpl>();

                var service = diBuilder.GetServices().First();

                Assert.AreEqual(1, diBuilder.GetServices().Count());
                Assert.AreEqual(typeof(IFooService), service.InterfaceType);
                Assert.AreEqual(typeof(FooServiceImpl), service.ImplementationType);
                Assert.AreEqual(RegistrationType.Singleton, service.RegistrationType);
            }

            [TestMethod]
            public void AddScopedService()
            {
                var diBuilder = new DiBuilder()
                    .AddScoped<IFooService, FooServiceImpl>();

                var service = diBuilder.GetServices().First();

                Assert.AreEqual(1, diBuilder.GetServices().Count());
                Assert.AreEqual(typeof(IFooService), service.InterfaceType);
                Assert.AreEqual(typeof(FooServiceImpl), service.ImplementationType);
                Assert.AreEqual(RegistrationType.Scoped, service.RegistrationType);
            }
        }
    }
}
