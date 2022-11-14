using ExamResults.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamResults
{
    internal class ExamResult : IComparable<ExamResult>
    {

        public Guid ID;
        public string Name;
        public Exams Exam;
        public Score Score;
        public DateTime Date;

        public ExamResult(Guid id, string name, Exams exam, Score score, DateTime date)
        {
            ID = id;
            Name = name;
            Exam = exam;
            Score = score;
            Date = date;

        }

        public int CompareTo(ExamResult other)
        {
            int result = Name.CompareTo(other.Name);
            //int resultOfIDComparing = ID.CompareTo(other.ID);
            if (result == 0)
            {
                result = Date.CompareTo(other.Date);

                if (result == 0)
                {
                    result = ID.CompareTo(other.ID);
                }

            }

            return result;



        }


    }
}