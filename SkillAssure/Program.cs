using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillAssure
{
    class Program
    {
        static void Main(string[] args)
        {
            TrainingModel trainingModel = new TrainingModel();

            Question question1 = new Question();
            Question question2 = new Question();
            Question question3 = new Question();
            Question question4 = new Question();
            Question question5 = new Question();
            Question question6 = new Question();
            Question question7 = new Question();
            Question question8 = new Question();
            Question question9 = new Question();
            Question question10 = new Question();
            question1.Setmark(2);
            question2.Setmark(2);
            question3.Setmark(2);
            question4.Setmark(2);
            question5.Setmark(2);
            question6.Setmark(2);
            question7.Setmark(2);
            question8.Setmark(2);
            question9.Setmark(2);
            question10.Setmark(2);

            
            Assessments assessments1 = new Assessments();
            assessments1.SetDescription("MCQQuestion");
            assessments1.SetTotalquestion(5);

            Assessments assessments2 = new Assessments();
            assessments2.SetDescription("HandsOnQuestion");
            assessments2.SetTotalquestion(5);

            assessments1.Questions.Add(question1);
            assessments1.Questions.Add(question2);
            assessments1.Questions.Add(question3);
            assessments1.Questions.Add(question4);
            assessments1.Questions.Add(question5);
            assessments2.Questions.Add(question6);
            assessments2.Questions.Add(question7);
            assessments2.Questions.Add(question8);
            assessments2.Questions.Add(question9);
            assessments2.Questions.Add(question10);

            Iteration iteration1 = new Iteration();
            iteration1.assessments.Add(assessments1);
            iteration1.assessments.Add(assessments2);

            trainingModel.Iterations.Add(iteration1);

            
            //assessments1.Questions.Add(question1);
            //for(int i=0;i<3;i++)
            //{
            //    trainingModel.iterations.Add(new Iteration()); 
            //}

            Console.WriteLine(trainingModel.getNumHandsOnBasedAssessment());
            Console.WriteLine(trainingModel.getNumMCQBasedAssessment());
            Console.WriteLine(trainingModel.getTotalAssessmentInTraining());
            Console.WriteLine(trainingModel.getTotalScoreOfAllAssessments());
        }
    }
}
