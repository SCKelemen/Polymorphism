using System;

namespace Poly.Models {
    public abstract class AbstractClass : IInterface
    {
        public void Write() 
        {
            Console.WriteLine("AbstractClass.Write");
        }

        public abstract void WriteAbstract();

        public virtual void WriteVirtual()
        {
            Console.WriteLine("AbstractClass.WriteVirtual");
        }

        public virtual void WriteVirtualNew()
        {
            Console.WriteLine("AbstractClass.WriteVirtualNew");
        }
        
    }
}