using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace anotherDart
{
    public class Dart
    {
        public Random randomNumber { get; set; }
        public int position { get; set; }
        public bool _double { get; set; }
        public bool triple { get; set; }

        public Dart(Random generator)
        {
            this.randomNumber = generator;
        }

        public void Throw()
        {
            position = this.randomNumber.Next(0, 20);

            if (position == 0)
            {
                if (this.randomNumber.Next(0, 100) < 5)
                {
                    this.position = 50;
                }
                else this.position = 25;
            }

            else if (randomNumber.Next(0, 100) < 5)
            {
                this._double = true;
            }
            else if (this.randomNumber.Next(0, 100) < 5)
            {
                this.triple = true;
            }

        }
    }
}