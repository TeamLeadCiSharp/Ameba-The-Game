using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using Ameba;
using System;

namespace UnitTestAmebaTheGame
{
    [TestClass]
    public class VirusClassTests
    {
        [TestMethod]
        public void GetPositionOfViruses_ShouldReturnCorrectCoordinates()
        {
            PictureBox ameba = new PictureBox();
            PictureBox virus = new PictureBox();
            virus.Left = 20;
            virus.Top = 30;

            var result = VirusClass.GetPositionOfViruses(ref virus);

            Assert.AreEqual((20, 30), result);
        }

        [TestMethod]
        public void MoveLeft_ShouldDecreaseLeftPosition()
        {
            PictureBox virus = new PictureBox();
            virus.Left = 30;
            int initialLeft = virus.Left;

            VirusClass virusexample = new VirusClass();
            virusexample.MoveLeft(ref virus);

            Assert.AreEqual(initialLeft - 50, virus.Left);
        }

        [TestMethod]
        public void MoveRight_ShouldIncreaseLeftPosition()
        {
            PictureBox virus = new PictureBox();
            virus.Left = 30;
            int initialLeft = virus.Left;

            VirusClass virusexample = new VirusClass();
            virusexample.MoveRight(ref virus);
            Assert.AreEqual(initialLeft + 50, virus.Left);
        }

        [TestMethod]
        public void MoveUp_ShouldDecreaseTopPosition()
        {
            PictureBox virus = new PictureBox();
            virus.Top = 40;
            int initialTop = virus.Top;

            VirusClass virusexample = new VirusClass();
            virusexample.MoveUp(ref virus);

            Assert.AreEqual(initialTop - 50, virus.Top);
        }

        [TestMethod]
        public void MoveDown_ShouldIncreaseTopPosition()
        {
            PictureBox virus = new PictureBox();
            virus.Top = 40;
            int initialTop = virus.Top;

            VirusClass virusexample = new VirusClass();
            virusexample.MoveDown(ref virus);

            Assert.AreEqual(initialTop + 50, virus.Top);
        }
    }
    [TestClass]
    public class AmebaClassTests
    {

        [TestMethod]
        public void TestMoveLeft()
        {
            PictureBox ameba = new PictureBox { Left = 100 };
            AmebaClass amebaClass = new AmebaClass(ameba);

            amebaClass.MoveLeft();

            Assert.IsTrue(ameba.Left == 50);
        }

        [TestMethod]
        public void TestEatAspirine()
        {
            PictureBox ameba = new PictureBox();
            PictureBox aspirine = new PictureBox();
            AmebaClass amebaClass = new AmebaClass(ameba);

            amebaClass.EatAspirine(ref ameba, ref aspirine);

            Assert.IsTrue(AmebaClass.Health == 100);
            Assert.IsFalse(aspirine.Visible);
        }
    }
    [TestClass]
    public class ItemClassTests
    {
        [TestMethod]
        public void TestSetPositionForBurger()
        {
            PictureBox burger = new PictureBox();
            ItemClass itemClass = new ItemClass();

            itemClass.SetPositionForBurger(ref burger);

            Assert.IsFalse(ItemClass.BurgerWasEaten);
            Assert.IsTrue(burger.Visible);
        }

        [TestMethod]
        public void TestSetPositionForAspirine()
        {
            PictureBox aspirine = new PictureBox();
            ItemClass itemClass = new ItemClass();

            itemClass.SetPositionForAspirine(ref aspirine);

            Assert.IsFalse(ItemClass.AspirineWasEaten);
            Assert.IsTrue(aspirine.Visible);
        }

        
    }
}
