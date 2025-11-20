using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using minimal_api.Dominio.DTOs;
using Minimalapi.Dominio.Entidades;

namespace Test.Domain.Entidades;

[TestClass]
public class VeiculoTeste
{
    [TestMethod]

    public void TestPropertiesGetSetVeiculos()
    {
        // Arrange
        var veiculoTeste = new Veiculo();

        // Act
        veiculoTeste.Id = 1;
        veiculoTeste.Nome = "SanderoDosCria";
        veiculoTeste.Marca = "Renault";
        veiculoTeste.Ano = 2017;

        // Assert
        Assert.AreEqual(1, veiculoTeste.Id);
        Assert.AreEqual("SanderoDosCria", veiculoTeste.Nome);
        Assert.AreEqual("Renault", veiculoTeste.Marca);
        Assert.AreEqual(2017, veiculoTeste.Ano);
    }
}