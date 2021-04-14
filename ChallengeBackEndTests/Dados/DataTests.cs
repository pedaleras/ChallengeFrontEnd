using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChallengeBackEnd.Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeBackEnd.Dados.Tests
{
    [TestClass()]
    public class DataTests
    {
        [TestMethod()]
        public void AddTest()
        {
            var dados = new Data();

            var salvar = dados.Add(new DataModel
            {
                Id = 1,
                FirstName = "Pedro",
                LastName = "Gomes",
                Participation = 40
            });


            Assert.IsTrue(salvar.status);
        }

        [TestMethod()]
        public void DeleteTest()
        {
            var dados = new Data();

            var delete = dados.Delete(1);

            Assert.IsTrue(delete.status);
        }

        [TestMethod()]
        public void GetListTest()
        {
            var dados = new Data();

            var lista = dados.GetList();

            Assert.IsTrue(lista.Status && lista.List.Count > 0);
        }


    }
}