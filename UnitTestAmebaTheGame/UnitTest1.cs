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
            PictureBox virus2 = new PictureBox();
            PictureBox virus3 = new PictureBox();
            virus.Left = 30;
            int initialLeft = virus.Left;

            VirusClass virusexample = new VirusClass();
            virusexample.MoveLeft(virus1: ref virus, virus2: ref virus2, virus3: ref virus3);

            Assert.AreEqual(initialLeft, virus.Left);
        }

        [TestMethod]
        public void MoveRight_ShouldIncreaseLeftPosition()
        {
            PictureBox virus1 = new PictureBox();
            PictureBox virus2 = new PictureBox();
            PictureBox virus3 = new PictureBox();
            virus1.Left = 30;
            int initialLeft = virus1.Left;

            VirusClass virusexample = new VirusClass();
            virusexample.MoveRight(virus1: ref virus1, virus2: ref virus2, virus3: ref virus3);
            Assert.AreEqual(initialLeft, virus1.Left);
        }

        [TestMethod]
        public void MoveUp_ShouldDecreaseTopPosition()
        {
            PictureBox virus1 = new PictureBox();
            PictureBox virus2 = new PictureBox();
            PictureBox virus3 = new PictureBox();
            virus1.Top = 40;
            int initialTop = virus1.Top;

            VirusClass virusexample = new VirusClass();
            virusexample.MoveUp(virus1: ref virus1,virus2: ref virus2, virus3: ref virus3);

            Assert.AreEqual(initialTop, virus1.Top);
        }

        [TestMethod]
        public void MoveDown_ShouldIncreaseTopPosition()
        {
            PictureBox virus1 = new PictureBox();
            PictureBox virus2 = new PictureBox();
            PictureBox virus3 = new PictureBox();
            virus1.Top = 40;
            int initialTop = virus1.Top;

            VirusClass virusexample = new VirusClass();
            virusexample.MoveDown(virus1: ref virus1, virus2: ref virus2, virus3: ref virus3);

            Assert.AreEqual(initialTop, virus1.Top);
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
