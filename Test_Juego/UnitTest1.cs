using Microsoft.VisualStudio.TestTools.UnitTesting;
using Libreria;
using System;

namespace Test_Juego
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCrearJuego()
        {
            var bowling = new Game();
        }

        [TestMethod]
        public void TestPeorJuego()
        {
            var bowling = new Game();

            for (int i = 0; i < 20; i++)
            {
                bowling.Tirar(0);
            }
            int result = bowling.Score();
            Assert.AreEqual(0,result);
        }

        [TestMethod]
        public void TestTodoUno()
        {
            var bowling = new Game();
            for (int i = 0; i < 20; i++)
            {
                bowling.Tirar(1);
            }
            int result = bowling.Score();
            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void TestUnSpare()
        {
            var bowling = new Game();
            bowling.Tirar(1);
            bowling.Tirar(9);
            for (int i = 0; i < 18; i++)
            {
                bowling.Tirar(1);
            }
            int result = bowling.Score();
            Assert.AreEqual(29, result);
        }


        [TestMethod]
        public void TestUnStrike()
        {
            var bowling = new Game();
            bowling.Tirar(1);
            bowling.Tirar(1);
            bowling.Tirar(10);
            for (int i = 0; i < 16; i++)
            {
                bowling.Tirar(1);
            }
            int result = bowling.Score();
            Assert.AreEqual(30, result);
        }

        [TestMethod]
        public void TestUnStrikeyUnSpare()
        {
            var bowling = new Game();
            bowling.Tirar(10);
            bowling.Tirar(1);
            bowling.Tirar(9);
            for (int i = 0; i < 16; i++)
            {
                bowling.Tirar(1);
            }
            int result = bowling.Score();
            Assert.AreEqual(47, result);
        }

        [TestMethod]
        public void TestJuegoPerfecto()
        {
            var bowling = new Game();
            for (int i = 0; i < 12; i++)
            {
                bowling.Tirar(10);
            }
            int result = bowling.Score();
            Assert.AreEqual(300, result);
        }
    }
}
