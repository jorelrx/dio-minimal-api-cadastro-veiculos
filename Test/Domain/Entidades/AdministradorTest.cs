using MinimalApi.Entidades;

namespace Test.Domain.Entidades;

[TestClass]
public class AdministradorTest
{
    [TestMethod]
    public void TestarGetSetPropriedades()
    {
        // Arrange
        
        var administrador = new Administrador();
        administrador.Id = 1;
        administrador.Email = "joao@example.com";
        administrador.Senha = "senha123";
        administrador.Perfil = "Adm";

        // Assert

        Assert.AreEqual(1, administrador.Id);
        Assert.AreEqual("joao@example.com", administrador.Email);
        Assert.AreEqual("senha123", administrador.Senha);
        Assert.AreEqual("Adm", administrador.Perfil);
    }
}