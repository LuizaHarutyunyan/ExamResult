using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using ExamResults;
using ExamResults;

namespace ExamResults
{
    [TestFixture]
    internal class Test
    {



        [Test]
        public void ExamResult_StudentsHaveSameName_CompareByDate()
        {
            ExamResult student1 = new ExamResult(Guid.NewGuid(), "Luiza", ExamResults.Enums.Exams.English, ExamResults.Enums.Score.A, new DateTime(2022, 10, 12));
            ExamResult student2 = new ExamResult(Guid.NewGuid(), "Luiza", ExamResults.Enums.Exams.English, ExamResults.Enums.Score.A, new DateTime(2022, 12, 12));
            var comparing = student1.CompareTo(student2);

            Assert.That(comparing == -1);
        }

        [Test]
        public void ExamResult_StudentsHaveDifferentNames_CompareByName()
        {
            ExamResult student1 = new ExamResult(Guid.NewGuid(), "A", ExamResults.Enums.Exams.English, ExamResults.Enums.Score.A, new DateTime(2022, 10, 12));
            ExamResult student2 = new ExamResult(Guid.NewGuid(), "B", ExamResults.Enums.Exams.English, ExamResults.Enums.Score.A, new DateTime(2022, 12, 12));
            var comparing = student1.CompareTo(student2);

            Assert.That(comparing == -1);
        }

        [Test]
        public void ExamResult_StudentsHaveDifferentNames_CompareByID()
        {
            var firstGuid = Guid.NewGuid();
            var secondGuid = Guid.NewGuid();
            ExamResult student1 = new ExamResult(firstGuid, "Anna", ExamResults.Enums.Exams.English, ExamResults.Enums.Score.A, new DateTime(2022, 12, 12));
            ExamResult student2 = new ExamResult(secondGuid, "Anna", ExamResults.Enums.Exams.English, ExamResults.Enums.Score.A, new DateTime(2022, 12, 12));
            var comparing = student1.CompareTo(student2);

            Assert.That(comparing == firstGuid.CompareTo(secondGuid));
        }




    }
}

