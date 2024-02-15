using School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ph_4_Proj_2
{
    [TestFixture]
    internal class TeacherTest
    {
        [Test]
        public void TestTeacherName()
        {
            Teacher myTeacher = new Teacher();
            myTeacher.Name = "John";
            string teacherName = myTeacher.Name;
            Assert.AreEqual("John", teacherName);
        }
        [Test]
        public void TestClassId()
        {
            Teacher myTeacher = new Teacher();
            myTeacher.Id = 112;
            int tecaherId = myTeacher.Id;
            Assert.AreEqual(112, tecaherId);
        }
    }
}
