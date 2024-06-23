using Exame_Wakim.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exame_Wakim
{
    /// <summary>
    /// Client
    /// </summary>
    public class TelemovelClient
    {
        ISmartPhone smartPhone;
        INormalPhone normalPhone;

        public TelemovelClient(ITelemovel telemovelfactory)
        {
            smartPhone = telemovelfactory.BuscarSmartPhone();
            normalPhone = telemovelfactory.BuscarNormalPhone();
        }

        public string BuscarSmartPhoneModeloDetalhes()
        {
            return smartPhone.BuscarDetalhesModelo();
        }

        public string BuscarNormalPhoneModeloDetalhes()
        {
            return normalPhone.BuscarDetalhesModelo();
        }



    }
}
