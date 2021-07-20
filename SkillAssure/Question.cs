using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillAssure
{
    public class Question
    {
        private int Marks;

        public void Setmark(int m)
        {
            Marks = m;
        }
        public int Getmark()
        {
            //int res = Marks;
            return Marks;
        }
    }
}
