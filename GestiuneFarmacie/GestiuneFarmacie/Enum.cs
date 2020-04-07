using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiuneFarmacie
{
    internal enum NumeForma
    {
        None =0,
        Capsula,
        Comprimate,
        Sirop,
        Drajeuri

    }
    [Flags]

    internal enum TipEliberare
    {
        None =0,
        Prescriptie =1,
        Fara_Prescriptie =2
    }
}
