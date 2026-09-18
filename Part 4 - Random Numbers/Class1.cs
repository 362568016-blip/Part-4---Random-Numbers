using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_4___Random_Numbers
{
    internal class Class1
    {
        public class Die
        {
            private int _sides;
            private int _roll;
            private Random _generator;
            private ConsoleColor _color;

            public Die()
            {
                _generator = new Random();
                _sides = 6;
                _roll = _generator.Next(1, _sides + 1);
                _color = ConsoleColor.Gray;
            }
            

            //properties
            public int Roll
            {
                get { return _roll; }
                //set { _roll = value; }
            }

            public ConsoleColor Color
            {
                get { return _color; }
                set { _color = value; }
            }

            public override string ToString()
            {
                return _roll.ToString();
            }

            public void RollDie()
            {
                _roll = _generator.Next(1, _sides + 1);
            }
        }
    }
}
