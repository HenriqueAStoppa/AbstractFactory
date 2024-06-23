using Exame_Wakim.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exame_Wakim
{
    /// <summary>
    /// ProdutoB1
    /// </summary>
    public class Nokia1600 : INormalPhone
    {
        public string BuscarDetalhesModelo()
        {
            return "Modelo: Nokia 1600\nRAM: NA\nCamera: NA\n";
        }
    }
}
