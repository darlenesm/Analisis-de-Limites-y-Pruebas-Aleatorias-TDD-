using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AL_y_PA
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidInput()
        {
            bool result = prueba.Program.Person("Darlene", "Sanz", "20");
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void ValidateInformationLength()
        {
            bool result;

            if (result = prueba.Program.length("Darlene", "Sanz", 20))
            {
                Assert.IsTrue(result);
            }
              
        }
 

        public void ValidateAgeLengt()
        {
            

            int age = 20;
            bool result = Convert.ToBoolean(age);

            if (age > 18 || age < 120)
            {
                Assert.IsTrue(result);
            }

        }

        public void ValidateNameLengt()
        {


            string name = "Darlene";
            bool result = Convert.ToBoolean(name);

            if (name > 2 || name < 64)
            {
                Assert.IsTrue(result);
            }

        }

        public void ValidateNameLengt()
        {


            string lastn = "Darlene";
            bool result = Convert.ToBoolean(lastn);

            if (lastn> 2 || lastn < 128)
            {
                Assert.IsTrue(result);
            }

        }

        public void EmptyName()
        {


            string name = "   ";
            bool result = Convert.ToBoolean(name);

            Assert.IsFalse(result);

        }

        public void EmptyLastName()
        {


            string lastn = "   ";
            bool result = Convert.ToBoolean(lastn);

            Assert.IsNull(result);

        }

        public void age()
        {


            string age = "   ";
            bool result = Convert.ToBoolean(age);

            Assert.IsNull(result);

        }
    }
