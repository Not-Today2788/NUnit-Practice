using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUINT
{
    [TestFixture]
    internal class MyTestCase
    {
        [Test]
        [TestCase(8,3,5)]
        [TestCase(31,20,11)]
        [TestCase(10,6,4)]
        public void Add(int a, int b, int c)
        {
            NunitDemo demo= new NunitDemo();
            Assert.That(a, Is.EqualTo (demo.Add(b, c)));
        }

        [TestCase]
        public void Sub()
        {
            NunitDemo demo = new NunitDemo();
            Assert.That(10, Is.EqualTo(demo.Sub(20, 10)));
        }
    }
}
