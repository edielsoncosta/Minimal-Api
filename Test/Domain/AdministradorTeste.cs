using Minimalapi.Dominio.Entidades;

namespace Test.Domain.Entidades;

[TestClass]

public class UnitTest1
{
    [TestMethod]
    public void TestGetSetProperties()
    {
        //Arrange
        var adm = new Administrador();

        // Act
        adm.Email = "teste@teste.com";
        adm.Senha = "teste";
        adm.Perfil = "Adm";
        adm.Id = 1;

        // Assert
        Assert.AreEqual("teste@teste.com", adm.Email);
        Assert.AreEqual("teste", adm.Senha);
        Assert.AreEqual("Adm", adm.Perfil);
        Assert.AreEqual(1, adm.Id);
    }
}