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
    public class PersonneTests
    {
        [TestMethod()]
        public void MajPrenomTest()
        {
            Personne p1 = new Personne("gouyon", "antoine", "11/02/1995");
            p1.MajPrenom();
            Assert.AreEqual("ANTOINE", p1.prenom);
        }
    }
}