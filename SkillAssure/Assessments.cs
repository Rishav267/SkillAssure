using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillAssure
{
    public class Assessments
    {
        public List<Question> Questions { get; set; } = new List<Question>();

        private string AssessmentId ;

        private string Desc ;

        private int NoQuestion;

        private DateTime dtAssessment;

        private int getTotalMarks;

        public void SetTotalquestion(int count)
        {
            NoQuestion = count;
        }
        public int GetTotalquestion()
        {
            //int count = NoQuestion;
            return NoQuestion;
        }

        public void SetDescription(string type)
        {
            Desc = type;
        }
        public string GetDescription()
        {
            //string res = Desc;
            return Desc;
        }

        //public int TotalMarks()
        //{
        //    int tot = getTotalMarks;
        //    return tot;
        //}

        public int GetMarks()
        {
            int Total = 0;
            foreach(var v in Questions)
            {
                Total += v.Getmark();
            }
            getTotalMarks = Total;
            return Total;
        }
    }
}
