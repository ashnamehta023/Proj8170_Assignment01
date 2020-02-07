using NUnit.Framework;

namespace Assignment01.Tests
{
    [TestFixture]
    public class RectangleTest
    {
        int actualValue;

        [SetUp]
        public void SetUp()
        {
           Rectangle rec = new Rectangle();
        }

        //Test Cases for GetLength()
        [Test]
        public void TestGetLength_Default_ExpectedLengthdefault()
        {
            Rectangle rec = new Rectangle();
            actualValue = rec.GetLength();
            Assert.AreEqual(1, actualValue);
        }

        [Test]
        public void TestGetLength_InputLength5_ExpectedLength5()
        {
            Rectangle rec = new Rectangle(5, 7);
            actualValue = rec.GetLength();
            Assert.AreEqual(5, actualValue);
        }

        [Test]
        public void TestGetLength_InputLength9_ExpectedLength9()
        {
            Rectangle rec = new Rectangle(9, 7);
            actualValue = rec.GetLength();
            Assert.AreEqual(9, actualValue);
        }

        [Test]
        public void TestGetLength_InputLength5_ExpectedLength6()
        {
            Rectangle rec = new Rectangle(5, 7);
            actualValue = rec.GetLength();
            Assert.AreEqual(6, actualValue, "Intentioanlly Failed Scenario");
        }

        //Test Cases for SetLength()
        [Test]
        public void TestSetLength_SetLengthTo3_ExpectedLength3()
        {
            Rectangle rec = new Rectangle(9, 5);
            actualValue = rec.SetLength(3);
            Assert.AreEqual(3, actualValue);
        }

        [Test]
        public void TestSetLength_SetLengthTo8_ExpectedLength8()
        {
            Rectangle rec = new Rectangle(9, 5);
            actualValue = rec.SetLength(8);
            Assert.AreEqual(8, actualValue);
        }

        [Test]
        public void TestSetLength_SetLengthTo6_ExpectedLength6()
        {
            Rectangle rec = new Rectangle(9, 5);
            actualValue = rec.SetLength(6);
            Assert.AreEqual(6, actualValue);
        }

        [Test]
        public void TestSetLength_SetLengthTo7_ExpectedLength3()
        {
            Rectangle rec = new Rectangle(1, 5);
            actualValue = rec.SetLength(7);
            Assert.AreEqual(3, actualValue, "Intentioanlly Failed Scenario");
        }

        //Test Cases for GetWidth()
        [Test]
        public void TestGetWidth_DefaultWidth_ExpectedWidth5()
        {
            Rectangle rec = new Rectangle();
            actualValue = rec.GetWidth();
            Assert.AreEqual(1, actualValue);
        }

        [Test]
        public void TestGetWidth_InputtWidth6_ExpectedWidth6()
        {
            Rectangle rec = new Rectangle(4, 6);
            actualValue = rec.GetWidth();
            Assert.AreEqual(6, actualValue);
        }

        [Test]
        public void TestGetWidth_InputWidth7_ExpectedWidth7()
        {
            Rectangle rec = new Rectangle(4, 7);
            actualValue = rec.GetWidth();
            Assert.AreEqual(7, actualValue);
        }

        [Test]
        public void TestGetWidth_InputWidth7_ExpectedWidth5()
        {
            Rectangle rec = new Rectangle(2, 7);
            actualValue = rec.GetWidth();
            Assert.AreEqual(5, actualValue, "Intentioanlly Failed Scenario");
        }

        //Test Cases for SetWidth()
        [Test]
        public void TestSetWidth_SetWidthTo7_ExpectedWidth7()
        {
            Rectangle rec = new Rectangle(9, 5);
            actualValue = rec.SetWidth(7);
            Assert.AreEqual(7, actualValue);
        }

        [Test]
        public void TestSetWidth_SetWidthTo2_ExpectedWidth2()
        {
            Rectangle rec = new Rectangle(9, 5);
            actualValue = rec.SetWidth(2);
            Assert.AreEqual(2, actualValue);
        }

        [Test]
        public void TestSetWidth_SetWidthTo6_ExpectedWidth6()
        {
            Rectangle rec = new Rectangle(9, 5);
            actualValue = rec.SetWidth(6);
            Assert.AreEqual(6, actualValue);
        }

        [Test]
        public void TestSetWidth_SetWidthTo4_ExpectedWidth6()
        {
            Rectangle rec = new Rectangle(1, 7);
            actualValue = rec.SetWidth(4);
            Assert.AreEqual(6, actualValue, "Intentioanlly Failed Scenario");
        }

        //Test Cases for GetPerimeter()
        [Test]
        public void TestGetPereimeter_Inputs8_5_ExpectedPerimeter26()
        {
            Rectangle rec = new Rectangle(8, 5);
            actualValue = rec.GetPerimeter();
            Assert.AreEqual(26, actualValue);
        }

        [Test]
        public void TestGetPereimeter_Inputs5_8_ExpectedPerimeter26()
        {
            Rectangle rec = new Rectangle(5, 8);
            actualValue = rec.GetPerimeter();
            Assert.AreEqual(26, actualValue);
        }

        [Test]
        public void TestGetPereimeter_Inputs6_5_ExpectedPerimeter22()
        {
            Rectangle rec = new Rectangle(6, 5);
            actualValue = rec.GetPerimeter();
            Assert.AreEqual(22, actualValue);
        }

        [Test]
        public void TestGetPereimeter_Inputs6_5_ExpectedPerimeter23()
        {
            Rectangle rec = new Rectangle(6, 5);
            actualValue = rec.GetPerimeter();
            Assert.AreEqual(23, actualValue, "Intentioanlly Failed Scenario");
        }

        //Test Cases for GetArea()
        [Test]
        public void TestGetArea_Inputs8_5_ExpectedArea40()
        {
            Rectangle rec = new Rectangle(8, 5);
            actualValue = rec.GetArea();
            Assert.AreEqual(40, actualValue);
        }

        [Test]
        public void TestGetArea_Inputs5_8_ExpectedArea40()
        {
            Rectangle rec = new Rectangle(5, 8);
            actualValue = rec.GetArea();
            Assert.AreEqual(40, actualValue);
        }

        [Test]
        public void TestGetArea_Inputs6_5_ExpectedArea30()
        {
            Rectangle rec = new Rectangle(6, 5);
            actualValue = rec.GetArea();
            Assert.AreEqual(30, actualValue);
        }

        [Test]
        public void TestGetArea_Inputs6_5_ExpectedArea35()
        {
            Rectangle rec = new Rectangle(6, 5);
            actualValue = rec.GetArea();
            Assert.AreEqual(35, actualValue, "Intentioanlly Failed Scenario");
        }

    }
}
