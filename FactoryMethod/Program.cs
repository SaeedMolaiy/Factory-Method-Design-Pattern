using System;
using FactoryMethod.Creators;

namespace FactoryMethod
{
    internal class Program
    {
        // The client code works with an instance of a concrete creator, albeit
        // through its base interface or class. As long as the client keeps working with
        // the creator via the base interface or class, you can pass it any creator's
        // subclass.
        static void Main(string[] args)
        {
            Creator qrCreator = new QrCodeCreator();
            Creator baeCodeCreator = new BarCodeCreator();

            var qrCode = qrCreator.FactoryMethod();
            var barCode = baeCodeCreator.FactoryMethod();

            qrCreator.SomeOperation();
            baeCodeCreator.SomeOperation();

            Console.WriteLine("-----------");

            qrCode.SomeOperation();
            barCode.SomeOperation();

            Console.ReadKey();
        }
    }
}
