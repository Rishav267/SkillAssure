using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillAssure
{
    public class TrainingModel
    {
        public List<Iteration> Iterations { get; set; } = new List<Iteration>();

        private string ClientName;

        public int getTotalAssessmentInTraining()
        {
            int total = 0;
            foreach(var v in Iterations)
            {
                foreach(var k in v.assessments)
                {
                    total += k.GetTotalquestion();
                   
                    
                }
            }
            return total;
        }

        public int getNumMCQBasedAssessment()
        {
            int count = 0;
            foreach(var v in Iterations)
            {
                foreach(var t in v.assessments)
                {
                    string temp = t.GetDescription();
                    if(temp == "MCQQuestion")
                    {
                        count += 1;
                    }
                }
            }
            return count;
        }

        public int getNumHandsOnBasedAssessment()
        {
            int count = 0;
            foreach (var v in Iterations)
            {
                foreach (var t in v.assessments)
                {
                    string temp = t.GetDescription();
                    if (temp == "HandsOnQuestion")
                    {
                        count += 1;
                    }
                }
            }
            return count;
        }

        public int getTotalScoreOfAllAssessments()
        {
            int TotalScore = 0;
            foreach (var v in Iterations)
            {
                foreach (var t in v.assessments)
                {
                    
                    TotalScore += t.GetMarks(); 
                   
                }
            }
            return TotalScore;
        }
    }
}
