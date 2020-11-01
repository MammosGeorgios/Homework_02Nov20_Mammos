using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationsOfTwoIntegers
{
    class Calculator
    {
        int x;
        int y;
        bool isOverloaded = false;

        // business logic
        // new Calculator(); <-- x = 0, y = 1 default constructor
        public Calculator()
        {
            isOverloaded = false;
            this.x = 0;
            this.y = 0;
        }

        // new Calculator(10, 20); overloaded constructor
        // new Caclulator(10, 0); <--- do not crash
        public Calculator(int x, int y)
        {
            isOverloaded = true;
            this.AssignFieldValues(x, y, false);
        }

        private void AssignFieldValues(int x, int y, bool useZero)
        {
            /*
             * const        values (x,y)     methods   result(add)   result(divide)
             * A ()           0,0              ()       A1 0 + 0       A2 0 / 1
             * B ()           0,0              (x, y)   B1 x + y       B2 x / (y = 1)
             * C (x, y)       x,y              ()       B1 x + y       B2 x / (y = 1)
             * D (x, y)       x,y              (i,j)    D1 i + j       D2 i / (j = 1)
             * E (x, y == 0)  x,y              ()       B1 x + y       B2 x / (y = 1)  
             * 
             * 
             * 1st case = A1
             * 2st case = A2
             * 3nd case = B1
             * 4th case = B2
             * 5th case = D1
             * 6th case = D2
             * 
             */

            this.x = x;
            if (y == 0 && useZero)
            {
                this.y = 1;
            }
            else
            {
                this.y = y;
            }
        }

        // Add(); / Subtract(); / Multiply(); / Divide();
        public int Add()
        {
            
            return (this.x + this.y);
        }

        public int Add(int x, int y)
        {
            this.AssignFieldValues(x, y, false);
            return (this.x + this.y);
        }

        public int Subtract()
        {
            
            return (this.x - this.y);
        }

        public int Subtract(int x, int y)
        {
            this.AssignFieldValues(x, y, false);
            return (this.x - this.y);
        }

        public int Multiply()
        {
            
            return (this.x * this.y);
        }

        public int Multiply(int x, int y)
        {
            this.AssignFieldValues(x, y, false);
            return (this.x * this.y);
        }

        public int Divide()
        {
            if (this.y == 0) return (this.x / 1);
            return (this.x / this.y);
        }

        public int Divide(int x, int y)
        {
            this.AssignFieldValues(x, y, true);
            return (this.x / this.y);
        }

        // < new Calculator(10, 20); / new Calculator(); >

        // Add(10,20); / Subtract(10,20); / Multiply(10,20); / Divide(10,20);
        // < new Calculator(100, 200); / new Calculator(); >

        public void TellMePleaseTheValuesOfTheFields()
        {
            Console.WriteLine($"{x}, {y}");
        }
    }
}