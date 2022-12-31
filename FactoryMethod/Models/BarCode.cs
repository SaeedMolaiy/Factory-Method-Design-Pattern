using System;

namespace FactoryMethod.Models
{
    // Concrete classes provide various implementations of the base
    public class BarCode : QrBarCode
    {
        public override void SomeOperation()
        {
            Console.WriteLine("BarCode SomeOperation();");
        }
    }
}
