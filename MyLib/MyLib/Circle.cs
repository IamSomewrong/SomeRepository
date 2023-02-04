using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class Circle : Figure
    {

        float _radius;

        public float Radius
        {
            get => _radius;
        }

        public Circle(float radius)
        {
            if(radius <= 0)
            {
                throw new Exception("Circle's radius must be non_negative");
            }
            _radius = radius;
        }

        public override double Area()
        {
            return Math.PI * _radius * _radius;
        }
    }
}
