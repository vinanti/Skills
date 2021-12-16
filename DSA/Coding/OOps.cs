using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding
{
    abstract class OOps
    {
        public abstract int Add();
        public int Addme()
        {
            return 7;
        }
    }
    class OOps2 : OOps, IInterface1
    {
        public override int Add()
        {
            
            //IInterface1 interface1 = new();
            return 5;
        }

        public int Add2()
        {
            return 1;
        }

        public int AddInterface()
        {
            throw new NotImplementedException();
        }
    }
    interface IInterface1
    {
        public int AddInterface();
        public int AddInterface2()
        {
            throw new NotImplementedException();
        }
    }
    class myOOps 
    {
        static void Main01()
        {
            OOps2 o2 = new OOps2();
            int o = o2.Add();
            //int i = o2.AddInterface();

            Child c = new Child();
            int c1 = c.Add();

            
        }
    }
    class Parrent
    {
        public virtual int Add()
        {
            return 0;
        }
    }
    class Child : Parrent
    {
        public override int Add()
        {
            return 2;
        }
    }
}