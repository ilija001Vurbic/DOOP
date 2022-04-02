using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV2_DOOP
{
    interface IModifiableDiceRoller
    {
        void InsertDie(Die die);
        void RemoveAllDice();
    }
}
