using Exame_Wakim.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exame_Wakim.ConcretsFactory
{
    /// <summary>
    /// ConcretFactory02
    /// </summary>
    public class Samsung : ITelemovel
    {
        public INormalPhone BuscarNormalPhone()
        {
            return new SamsungGuru();
        }

        public ISmartPhone BuscarSmartPhone()
        {
            return new SamsungGalaxy();
        }
    }
}
