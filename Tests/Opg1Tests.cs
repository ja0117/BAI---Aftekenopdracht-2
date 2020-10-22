using NUnit.Framework;

namespace BAI
{
    [TestFixture]
    public class Opg1Tests
    {
        [TestCase((uint)1, (uint)1)]
        [TestCase((uint)8, (uint)0)]
        [TestCase((uint)18, (uint)2)]
        [TestCase((uint)21, (uint)5)]
        [TestCase((uint)34, (uint)2)]
        [TestCase((uint)35, (uint)3)]
        [TestCase((uint)47, (uint)7)]
        [TestCase((uint)52, (uint)4)]
        [TestCase((uint)60, (uint)4)]
        [TestCase((uint)69, (uint)5)]
        [TestCase((uint)73, (uint)1)]
        [TestCase((uint)86, (uint)6)]
        [TestCase((uint)99, (uint)3)]
        [TestCase((uint)103, (uint)7)]
        [TestCase((uint)112, (uint)0)]
        [TestCase((uint)120, (uint)0)]
        [TestCase((uint)125, (uint)5)]
        [TestCase((uint)137, (uint)1)]
        [TestCase((uint)138, (uint)2)]
        [TestCase((uint)151, (uint)7)]
        [TestCase((uint)154, (uint)2)]
        [TestCase((uint)164, (uint)4)]
        [TestCase((uint)171, (uint)3)]
        [TestCase((uint)177, (uint)1)]
        [TestCase((uint)188, (uint)4)]
        [TestCase((uint)190, (uint)6)]
        [TestCase((uint)203, (uint)3)]
        [TestCase((uint)205, (uint)5)]
        [TestCase((uint)216, (uint)0)]
        [TestCase((uint)222, (uint)6)]
        [TestCase((uint)229, (uint)5)]
        [TestCase((uint)239, (uint)7)]
        [TestCase((uint)242, (uint)2)]
        [TestCase((uint)255, (uint)7)]
        public void Bit012_ID(uint b, uint expected)
        {
            // Act
            uint actual = BAI_Afteken2.ID(b);

            // Assert
            Assert.AreEqual(expected, actual);
        }


        [TestCase((uint)1, false)]
        [TestCase((uint)8, true)]
        [TestCase((uint)18, false)]
        [TestCase((uint)21, false)]
        [TestCase((uint)34, false)]
        [TestCase((uint)35, false)]
        [TestCase((uint)47, true)]
        [TestCase((uint)52, false)]
        [TestCase((uint)60, true)]
        [TestCase((uint)69, false)]
        [TestCase((uint)73, true)]
        [TestCase((uint)86, false)]
        [TestCase((uint)99, false)]
        [TestCase((uint)103, false)]
        [TestCase((uint)112, false)]
        [TestCase((uint)120, true)]
        [TestCase((uint)125, true)]
        [TestCase((uint)137, true)]
        [TestCase((uint)138, true)]
        [TestCase((uint)151, false)]
        [TestCase((uint)154, true)]
        [TestCase((uint)164, false)]
        [TestCase((uint)171, true)]
        [TestCase((uint)177, false)]
        [TestCase((uint)188, true)]
        [TestCase((uint)190, true)]
        [TestCase((uint)203, true)]
        [TestCase((uint)205, true)]
        [TestCase((uint)216, true)]
        [TestCase((uint)222, true)]
        [TestCase((uint)229, false)]
        [TestCase((uint)239, true)]
        [TestCase((uint)242, false)]
        [TestCase((uint)255, true)]
        public void Bit3_Licht(uint b, bool expected)
        {
            // Act
            bool actual = BAI_Afteken2.Licht(b);

            // Assert
            Assert.AreEqual(expected, actual);
        }


        [TestCase((uint)1, false)]
        [TestCase((uint)8, false)]
        [TestCase((uint)18, true)]
        [TestCase((uint)21, true)]
        [TestCase((uint)34, false)]
        [TestCase((uint)35, false)]
        [TestCase((uint)47, false)]
        [TestCase((uint)52, true)]
        [TestCase((uint)60, true)]
        [TestCase((uint)69, false)]
        [TestCase((uint)73, false)]
        [TestCase((uint)86, true)]
        [TestCase((uint)99, false)]
        [TestCase((uint)103, false)]
        [TestCase((uint)112, true)]
        [TestCase((uint)120, true)]
        [TestCase((uint)125, true)]
        [TestCase((uint)137, false)]
        [TestCase((uint)138, false)]
        [TestCase((uint)151, true)]
        [TestCase((uint)154, true)]
        [TestCase((uint)164, false)]
        [TestCase((uint)171, false)]
        [TestCase((uint)177, true)]
        [TestCase((uint)188, true)]
        [TestCase((uint)190, true)]
        [TestCase((uint)203, false)]
        [TestCase((uint)205, false)]
        [TestCase((uint)216, true)]
        [TestCase((uint)222, true)]
        [TestCase((uint)229, false)]
        [TestCase((uint)239, false)]
        [TestCase((uint)242, true)]
        [TestCase((uint)255, true)]
        public void Bit4_Wagon(uint b, bool expected)
        {
            // Act
            bool actual = BAI_Afteken2.Wagon(b);

            // Assert
            Assert.AreEqual(expected, actual);
        }


        [TestCase((uint)1, 0)]
        [TestCase((uint)8, 0)]
        [TestCase((uint)18, 0)]
        [TestCase((uint)21, 0)]
        [TestCase((uint)34, 33)]
        [TestCase((uint)35, 33)]
        [TestCase((uint)47, 33)]
        [TestCase((uint)52, 33)]
        [TestCase((uint)60, 33)]
        [TestCase((uint)69, 67)]
        [TestCase((uint)73, 67)]
        [TestCase((uint)86, 67)]
        [TestCase((uint)99, 100)]
        [TestCase((uint)103, 100)]
        [TestCase((uint)112, 100)]
        [TestCase((uint)120, 100)]
        [TestCase((uint)125, 100)]
        [TestCase((uint)137, 0)]
        [TestCase((uint)138, 0)]
        [TestCase((uint)151, 0)]
        [TestCase((uint)154, 0)]
        [TestCase((uint)164, 33)]
        [TestCase((uint)171, 33)]
        [TestCase((uint)177, 33)]
        [TestCase((uint)188, 33)]
        [TestCase((uint)190, 33)]
        [TestCase((uint)203, 67)]
        [TestCase((uint)205, 67)]
        [TestCase((uint)216, 67)]
        [TestCase((uint)222, 67)]
        [TestCase((uint)229, 100)]
        [TestCase((uint)239, 100)]
        [TestCase((uint)242, 100)]
        [TestCase((uint)255, 100)]
        public void Bit56_Vermogen(uint b, int expected)
        {
            // Act
            uint actual = BAI_Afteken2.Vermogen(b);

            // Assert
            Assert.AreEqual(expected, actual);
        }


        [TestCase((uint)1, false)]
        [TestCase((uint)8, false)]
        [TestCase((uint)15, false)]
        [TestCase((uint)21, false)]
        [TestCase((uint)22, false)]
        [TestCase((uint)29, false)]
        [TestCase((uint)34, false)]
        [TestCase((uint)36, false)]
        [TestCase((uint)43, false)]
        [TestCase((uint)47, false)]
        [TestCase((uint)50, false)]
        [TestCase((uint)57, false)]
        [TestCase((uint)60, false)]
        [TestCase((uint)64, false)]
        [TestCase((uint)71, false)]
        [TestCase((uint)73, false)]
        [TestCase((uint)78, false)]
        [TestCase((uint)85, false)]
        [TestCase((uint)86, false)]
        [TestCase((uint)92, false)]
        [TestCase((uint)99, false)]
        [TestCase((uint)106, false)]
        [TestCase((uint)112, false)]
        [TestCase((uint)113, false)]
        [TestCase((uint)120, false)]
        [TestCase((uint)125, false)]
        [TestCase((uint)127, false)]
        [TestCase((uint)134, true)]
        [TestCase((uint)138, true)]
        [TestCase((uint)141, true)]
        [TestCase((uint)148, true)]
        [TestCase((uint)151, true)]
        [TestCase((uint)155, true)]
        [TestCase((uint)162, true)]
        [TestCase((uint)164, true)]
        [TestCase((uint)169, true)]
        [TestCase((uint)176, true)]
        [TestCase((uint)177, true)]
        [TestCase((uint)183, true)]
        [TestCase((uint)190, true)]
        [TestCase((uint)197, true)]
        [TestCase((uint)203, true)]
        [TestCase((uint)204, true)]
        [TestCase((uint)211, true)]
        [TestCase((uint)216, true)]
        [TestCase((uint)218, true)]
        [TestCase((uint)225, true)]
        [TestCase((uint)229, true)]
        [TestCase((uint)232, true)]
        [TestCase((uint)239, true)]
        [TestCase((uint)242, true)]
        [TestCase((uint)246, true)]
        [TestCase((uint)253, true)]
        [TestCase((uint)255, true)]
        public void Bit7_Vooruit(uint b, bool expected)
        {
            // Act
            bool actual = BAI_Afteken2.Vooruit(b);

            // Assert
            Assert.AreEqual(expected, actual);
        }


    }
}