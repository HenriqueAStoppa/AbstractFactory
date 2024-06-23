using Exame_Wakim.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exame_Wakim
{
    /// <summary>
    /// ProdutoA2
    /// </summary>
    public class SamsungGalaxy : ISmartPhone
    {
        public string BuscarDetalhesModelo()
        {
            return "Modelo: Samsung Galaxy\nRAM: 2GB\nCamera: 13MP\n";
        }
    }
}
