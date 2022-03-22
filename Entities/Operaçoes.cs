using System;


namespace Calculadora
{
    public class Operaçoes
    {
        public double X;
        public double Y;

        public Operaçoes(double x, double y){
            X = x;
            Y = y;
        }

        public double Sum(int oper){
            return X + Y;
        }

        public double Subtract(int oper){
            return X - Y;
        }

        public double Multiplic(int oper){
            return X * Y;
        }

        public double Divide(int oper){
            return X / Y;
        }

    }
}