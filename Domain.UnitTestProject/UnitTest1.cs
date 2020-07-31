using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MeExpress.Domain;

namespace Domain.UnitTestProject
{
    [TestClass]
    public class ClienteUnitTeste
    {
        [TestMethod]
        public void ClienteTeste()
        {
            var cli = new Cliente
            {
                Id = Guid.NewGuid().ToString(),
                Nome = "Maria Exemplo da Silva",
                CPF = "487.027.288-18",
                Email = "lucastorres_candido@hotmail.com",
                Empresa = "Empresa ACME",
                Endereco = "Av Etc e Tal",
                Numero = "1234",
                Complemento = "Sala 23",
                Bairro = "Vila Exemplo"
            };

            Console.WriteLine(cli.Id);
            Console.WriteLine(cli.Nome);
            Console.WriteLine(cli.CPF);
            Console.WriteLine(cli.Email);
            Console.WriteLine(cli.Empresa);
            Console.WriteLine(cli.Endereco);
            Console.WriteLine(cli.Numero);
            Console.WriteLine(cli.Complemento);
            Console.WriteLine(cli.Bairro);
            Console.WriteLine(cli.Cidade);
            Console.WriteLine(cli.Estado);

            Assert.AreEqual("São Paulo", cli.Cidade, "A cidade não está sendo preenchida automaticamente.");

        }
    }
}
