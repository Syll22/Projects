using System;

namespace My_First_Example_App
{
    public class Calculator
    {
        public int primulOperad;
        public int alDoileaOperand;

        public Calculator()
        {

        }

        public void Operatie(string tipulOperatiei)
        {
            switch (tipulOperatiei)
            {
                case "+":
                    Console.WriteLine(primulOperad + " + " + alDoileaOperand + " = " + Adunare());
                    break;

                case "-":
                    Console.WriteLine(primulOperad + " - " + alDoileaOperand + " = " + Scadere());
                    break;

                case "*":
                    Console.WriteLine(primulOperad + " * " + alDoileaOperand + " = " + Inmultire());
                    break;

                case "/":
                    Console.WriteLine(primulOperad + " / " + alDoileaOperand + " = " + Impartire());
                    break;
            }
        }

        //+
        private int Adunare()
        {
            return primulOperad + alDoileaOperand;
        }

        //-
        private int Scadere()
        {
            return primulOperad - alDoileaOperand;
        }

        //*
        private int Inmultire()
        {
            return primulOperad * alDoileaOperand;
        }

        // "/"
        private double Impartire()
        {
            if (alDoileaOperand == 0)
            {
                throw new Exception("Impartitrea la 0 nu are sens!");
            }

            return ((double) primulOperad / (double) alDoileaOperand);
        }
    }
}