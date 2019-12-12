using System;
using BID.SWE1.Exam.Interfaces;

namespace BID.SWE.EXAM.Impl
{
    public class Exercise2 : IExercise2
    {
        public object Method1()
        {
            var x = new NormalCell();
            return x;
        }

        public int Method2()
        {
            var x = new CancerCell();
            return x.Grow();
        }

        public bool Method3(int o1)
        {
            var x = new CellWithFriends();
            return x.IsAlive(o1);
        }
    }

    public class NormalCell : Cell
    {
        string Talk()
        {
            return "i am normal!!";
        }
    }
    public class CancerCell : Cell
    {
        public override int Grow()
        {
            _size *= 2;
            return _size;
        }
    }
    public class CellWithFriends : Cell
    {
        public bool IsAlive(int neighbour)
        {
            if (neighbour % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}