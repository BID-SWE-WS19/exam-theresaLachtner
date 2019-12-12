using System;
using BID.SWE1.Exam.Interfaces;

namespace BID.SWE.EXAM.Impl
{
    public class Exercise3 : IExercise3
    {
        public object Method1()
        {
            throw new NotImplementedException();
        }

        public object Method2()
        {
            Bewegung[] _bewegung = new Bewegung[2];
            _bewegung[0] = new Springen();
            _bewegung[1] = new Laufen();
            return _bewegung;
        }
    }

    public class Bewegung
    {
        public virtual string Move (int x)
        {
            return "";
        }
        public virtual string Position()
        {
            return "";
        }
    }
    public class Springen : Bewegung
    {
        public override string Move(int x)
        {
            return "x";
        }
    }
    public class Laufen : Bewegung
    {
        public override string Position()
        {
            return "y";
        }
    }
}