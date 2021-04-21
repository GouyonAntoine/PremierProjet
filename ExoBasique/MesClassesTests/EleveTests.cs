using Microsoft.VisualStudio.TestTools.UnitTesting;
using MesClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesClasses.Tests
{
    [TestClass()]
    public class EleveTests
    {
        [TestMethod()]
        public void EleveTest()
        {

            //Arrange 
            int a = 15;
            string n = "Gouyon";
            double m = 15;

            //Act
            Eleve eTest = new Eleve(n, a, m);
            Assert.AreEqual(15, eTest.age);
        }
    }
}