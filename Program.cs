using System;
using Poly.Models; 

namespace polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteClass concrete = new ConcreteClass();
            AbstractClass abstractClass = concrete;
            IInterface interfaceConcrete = concrete;
            IInterface interfaceAbstract = abstractClass;

            Console.WriteLine("Concrete");
            concrete.Write();
            concrete.WriteAbstract();
            concrete.WriteVirtual();
            concrete.WriteVirtualNew();

            Console.WriteLine();
            Console.WriteLine("Abstract");
            abstractClass.Write();
            abstractClass.WriteAbstract();
            abstractClass.WriteVirtual();
            abstractClass.WriteVirtualNew();

            Console.WriteLine();
            Console.WriteLine("InterfaceConcrete");
            interfaceConcrete.Write();
            interfaceConcrete.WriteAbstract();
            interfaceConcrete.WriteVirtual();
            interfaceConcrete.WriteVirtualNew();

            Console.WriteLine();
            Console.WriteLine("InterfaceAbstract");
            interfaceAbstract.Write();
            interfaceAbstract.WriteAbstract();
            interfaceAbstract.WriteVirtual();
            interfaceAbstract.WriteVirtualNew();

            Console.ReadKey();
        }
    }
}
