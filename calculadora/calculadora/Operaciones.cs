using System;
using System.Collections.Generic;
using System.Text;

namespace calculadora
{
    class Operaciones
    {
       private  float num1, num2;

        public Operaciones(float num1, float num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public float Num1 { get => num1; set => num1 = value; }
        public float Num2 { get => num2; set => num2 = value; }

        public  float suma()
        {
            
            return this.num1 + this.num2;
        }
        public float resta()
        {
            return num1 - num2;
        }
        public float multiplicacion()
        {
            return num1 * num2;
        }
        public float divicion()
        {
            return num1 / num2;
        }

    }
}
