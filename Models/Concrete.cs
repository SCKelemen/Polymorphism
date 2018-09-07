using System;

namespace Poly.Models {
    public class ConcreteClass : AbstractClass, IInterface
    {
        public new void Write() 
        {
            Console.WriteLine("ConcreteClass.Write");
        }
        public override void WriteAbstract()
        {
            Console.WriteLine("ConcreteClass.WriteAbstract");
        }
        public override void WriteVirtual()
        {
            Console.WriteLine("ConcreteClass.WriteVirtual");
        }
        public new void WriteVirtualNew()
        {
            Console.WriteLine("ConcreteClass.WriteVirtualNew");
        }
    }
}