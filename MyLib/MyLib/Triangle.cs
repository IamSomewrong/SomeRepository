using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class Triangle : Figure
    {
        float _firstSide;
        float _secondSide;
        float _thirdSide;
        bool _isRight;

        public float FirstSide
        {
            get => _firstSide;
        }

        public float SecondSide
        {
            get => _secondSide;
        }

        public float ThirdSide
        {
            get => _thirdSide;
        }

        public bool IsRight
        {
            get => _isRight;
        }


        public Triangle(float first, float second, float third)
        {
            if(first <= 0 || second <= 0 || third <= 0)
            {
                throw new Exception("Triangle's side must be non-negative");
            }
            _firstSide = first;
            _secondSide = second;
            _thirdSide = third;
            _isRight = CheckIsRight();
        }

        private bool CheckIsRight()
        {
            float maxSide = new float[3] { _firstSide, _secondSide, _thirdSide }.Max();
            float maxSideSqr = maxSide * maxSide;
            return maxSideSqr + maxSideSqr == _firstSide * _firstSide + _secondSide * _secondSide + _thirdSide * _thirdSide;
        }

        public override double Area()
        {
            float p = (_firstSide + _secondSide + _thirdSide) / 2;

            return Math.Sqrt(p * (p - _firstSide) * (p - _secondSide) * (p - _thirdSide));
        }
    }
}
