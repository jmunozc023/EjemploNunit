using NUnit.Framework;
using EjemploNunit;

namespace TestProject1
{
    public class Tests
    {
        [TestFixture]
        public class BaseTest
        {
            private Base _EjemploNunit;

            [SetUp]
            public void Setup()
            {
                _EjemploNunit = new Base();
            }

            [Test]
            public void CrearMundo1()
            {
                var c = new Base();
                var r = c.CreaMundo(1);
                Assert.AreEqual("Mundo Magico", r);

            }
            public void CrearMundo2()
            {
                var c = new Base();
                var r = c.CreaMundo(2);
                Assert.AreEqual("Mundo Electrico", r);
            }
            public void CrearMundo3()
            {
                var c = new Base();
                var r = c.CreaMundo(3);
                Assert.AreEqual("Mundo Acuatico", r);
            }
        }
    }
}