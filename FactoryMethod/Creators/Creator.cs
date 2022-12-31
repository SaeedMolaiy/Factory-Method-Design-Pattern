using System;
using FactoryMethod.Models;

namespace FactoryMethod.Creators
{
    // The Creator class declares the factory method that is supposed to return
    // an object of a target class. The Creator's subclasses usually provide
    // the implementation of this method.
    public abstract class Creator
    {
        // Note that the Creator may also provide some default implementation of
        // the factory method.
        public abstract QrBarCode FactoryMethod();

        // Also note that, despite its name, the Creator's primary
        // responsibility is not creating classes. Usually, it contains some
        // core business logic that relies on objects, returned by the
        // factory method. Subclasses can indirectly change that business logic
        // by overriding the factory method and returning a different type of
        // product from it.
        public void SomeOperation()
        {
            Console.WriteLine("Creator SomeOperation()");
        }
    }
}
