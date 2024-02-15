using School;

namespace Ph_4_Proj_2
{
        internal class StudentTest
        {
            [Test]
            public void TestStudentName()
            {
               Student student = new Student();
               student.Name = "Moses";
               string studentName = student.Name;
               Assert.AreEqual("Moses", studentName);
        }
             [Test]
             public void TestStudentAddress()
             {
                Student student = new Student();
                student.Address = "Vizag";
                string studentAddress = student.Address;
                Assert.AreEqual("Vizag", studentAddress);
             }
        }
}