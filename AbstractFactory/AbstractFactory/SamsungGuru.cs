using Exame_Wakim.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exame_Wakim
{
    /// <summary>
    /// ProdutoB2
    /// </summary>
    public class SamsungGuru : INormalPhone
    {
        public string BuscarDetalhesModelo()
        {
            return "Modelo: Samsung Guru\nRAM: NA\nCamera: NA\n";
        }
    }
}
