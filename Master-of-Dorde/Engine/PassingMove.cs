using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Master_of_Dorde;

namespace Master_of_Dorde.Engine
{
    class PassingMove
    {
        static public void PassAMove(Person Player)
        {
            Player.Health -= 25;
        }
    }
}
