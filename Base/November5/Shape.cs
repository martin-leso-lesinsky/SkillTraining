using System;

namespace SkillTraining.Base.November5

{
    class Shape
    {
        double a;

        public void Square(double length)
        {
            this.a = length;
        }

        public virtual double Circuit()
        {
            return 4 * a;
        }
    }
}