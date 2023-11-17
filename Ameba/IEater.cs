using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ameba
{
    internal interface IEater
    {
        void EatBurger(ref PictureBox Ameba, ref PictureBox Burger);
        void EatAspirine(ref PictureBox Ameba, ref PictureBox Aspirine);
    }
}
