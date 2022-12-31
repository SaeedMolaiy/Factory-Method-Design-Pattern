using System;

namespace FactoryMethod.Models
{
    // Concrete classes provide various implementations of the base
    public class QrCode : QrBarCode
    {
        public override void SomeOperation()
        {
            Console.WriteLine("QrCode SomeOperation();");
        }
    }
}
