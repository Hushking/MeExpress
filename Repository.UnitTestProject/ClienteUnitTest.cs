using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MeExpress.Domain;
using MeExpress.Repository;


namespace Repository.UnitTestProject
{
    [TestClass]
    public class ClienteUnitTest
    {
        [TestMethod]
        public void ClienteNovoTest()
        {
            var clienteRep = new ClienteRepository();
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

            clienteRep.Incluir(cli);

            Cliente clienteGravado = clienteRep.ObterPorCpf("487.027.288-18");

            if (clienteGravado != null)
            {
                Console.WriteLine(clienteGravado.Id);
                Console.WriteLine(clienteGravado.Nome);
                Console.WriteLine(clienteGravado.CPF);
                Console.WriteLine(clienteGravado.Email);
                Console.WriteLine(clienteGravado.Empresa);
                Console.WriteLine(clienteGravado.Endereco);
                Console.WriteLine(clienteGravado.Numero);
                Console.WriteLine(clienteGravado.Complemento);
                Console.WriteLine(clienteGravado.Bairro);
                Console.WriteLine(clienteGravado.Cidade);
                Console.WriteLine(clienteGravado.Estado);
            }

            Assert.IsNotNull(clienteGravado, "Cliente não encontrado.");
        }
    }
}
