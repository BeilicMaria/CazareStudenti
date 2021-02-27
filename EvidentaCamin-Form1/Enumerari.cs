//Beilic Maria 3122B

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaCamin_Form1
{
    [Flags]
    public enum CodEroare
    {
        CORECT = 0,
        NUME_INCORECT = 1,
        PRENUME_INCORECT = 2,
        DISTANTA_INCORECTA=4,
        AN_INCORECT=8,
        FACULTATE_INCORECTA=16,
        CAMIN_INCORECT=32,
        CAMERA_INCORECTA=64,
        STUD_INCORECT=128
    }
}
