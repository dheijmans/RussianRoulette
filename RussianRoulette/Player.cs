using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussianRoulette
{
    class Player
    {
        string name;
        bool alive;
        bool pass;
        bool barrel;
        internal Player(string name)
        {
            this.name = name;
            alive = true;
            pass = false;
            barrel = false;
        }
        internal string Name
        {
            get { return name; }
            set { name = value; }
        }
        internal bool Alive
        {
            get { return alive; }
            set { alive = value; }
        }
        internal bool Pass
        {
            get { return pass; }
            set { pass = value; }
        }
        internal bool Barrel
        {
            get { return barrel; }
            set { barrel = value; }
        }
    }
}
