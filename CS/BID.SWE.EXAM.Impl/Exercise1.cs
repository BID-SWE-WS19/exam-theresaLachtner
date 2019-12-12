using System;
using BID.SWE1.Exam.Interfaces;

namespace BID.SWE.EXAM.Impl
{
    public class Exercise1 : IExercise1
    {
        public object Method1()
        {
            ICellPrinter x = new CellPrinter();
            return x;
        }

       
    }
    
    public class CellPrinter : ICellPrinter
    {
        string ICellPrinter.PrintState(bool alive, DateTime date, string color)
        {
            string _state = "Cell ";
            _state += color + " ";
            _state += "born on " + date.ToString() + " is ";
            if (alive)
            {
                _state += "alive";
            }
            else
            {
                _state += "dead";
            }

            return _state;
        }

        public string PrintPostion(int x, int y)
        {
            string _position = "Cell is on position ";
            string xval = "X: " + x.ToString();
            string yval = "Y: " + y.ToString();
            _position += xval + " " + yval;
            return _position;
        }
    }
}
