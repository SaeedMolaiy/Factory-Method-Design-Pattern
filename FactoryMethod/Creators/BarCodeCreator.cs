using FactoryMethod.Models;

namespace FactoryMethod.Creators
{
    public class BarCodeCreator : Creator
    {
        public override QrBarCode FactoryMethod()
        {
            return new BarCode();
        }
    }
}
