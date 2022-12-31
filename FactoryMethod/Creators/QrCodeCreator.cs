using FactoryMethod.Models;

namespace FactoryMethod.Creators
{
    public class QrCodeCreator : Creator
    {
        public override QrBarCode FactoryMethod()
        {
            return new QrCode();
        }
    }
}
