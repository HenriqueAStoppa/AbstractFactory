using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exame_Wakim.Interfaces
{
    /// <summary>
    /// Abstract Factory
    /// </summary>
    public interface ITelemovel
    {
        ISmartPhone BuscarSmartPhone();
        INormalPhone BuscarNormalPhone();

    }
}
