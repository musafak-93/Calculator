using NUnit.Framework;
using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    [TestFixture()]
    public class CalculatorTests
    {
        //membuat obyek baru Calculator
        Calculator cc = new Calculator();

        [SetUp]
        public void init()
        {
            cc = new Calculator();
        }

        [Test()]
        public void TambahTest()
        {
            //Assert.Fail();
            double hasilTb = cc.Tambah(4, 5);
            Assert.AreEqual(9, hasilTb);
        }

        [Test()]
        public void KaliTest()
        {
            //Assert.Fail();
            double hasilKl = cc.Kali(4, 5);
            Assert.AreEqual(20, hasilKl);
        }

        [Test()]
        public void BagiTest()
        {
            //Assert.Fail();
            double hasilBg = cc.Bagi(4, 5);
            Assert.AreEqual(0.8, hasilBg);
        }
    }
}