using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParcialNicoleSoruco.Controllers;

namespace UnitTestsoruco
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TesTGet()
        {
            //Arrange

            SorucoesController sorucocontroller = new SorucoesController();


            //Act
            var Resultado = sorucocontroller.GetSorucoes();


            //Assert
            Assert.IsNotNull(Resultado);


        }
    }
}
