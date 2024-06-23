using Exame_Wakim.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exame_Wakim.ConcretsFactory
{
    /// <summary>
    /// ConcretFactory01
    /// </summary>
    public class Nokia : ITelemovel
    {
        public INormalPhone BuscarNormalPhone()
        {
            return new Nokia1600();
        }

        public ISmartPhone BuscarSmartPhone()
        {
            return new NokiaPixel();
        }
    }
}
