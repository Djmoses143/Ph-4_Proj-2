using School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ph_4_Proj_2
{
    internal class SubjectTest
    {
        [Test]
        public void TestSubjectName()
        {
            Subject subject = new Subject();
            subject.Name = "Biology";
            string subjectName = subject.Name;
            Assert.AreEqual("Biology", subjectName);
        }

        [Test]
        public void TestSubjectId()
        {

            Subject subject = new Subject();
            subject.Id = 12;
            int subjectId = subject.Id;
            Assert.AreEqual(12, subjectId);
        }
    }
}
