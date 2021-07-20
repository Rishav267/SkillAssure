using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillAssure
{
    public class Course
    {
        public List<Assessments> theAssessment { get; set; } = new List<Assessments>();
        private string courseId;
        private string name;
    }
}
