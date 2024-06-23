using Exame_Wakim.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exame_Wakim
{
    /// <summary>
    /// ProdutoA1
    /// </summary>
    public class NokiaPixel : ISmartPhone
    {
        public string BuscarDetalhesModelo()
        {
            return "Modelo: Nokia Pixel\nRAM: 3GB\nCamera: 8MP\n";
        }
    }
}
