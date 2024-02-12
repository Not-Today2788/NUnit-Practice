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
        [TestCase]
        public void Add()
        {
            NunitDemo demo= new NunitDemo();
            Assert.That(31, Is.EqualTo (demo.Add(20, 11)));
        }

        [TestCase]
        public void Sub()
        {
            NunitDemo demo = new NunitDemo();
            Assert.That(10, Is.EqualTo(demo.Sub(20, 10)));
        }
    }
}
