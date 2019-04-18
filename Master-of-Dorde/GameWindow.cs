using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Master_of_Dorde.Engine;

namespace Master_of_Dorde
{
    public partial class GameWindow : Form
    {
        private Person Character;

        public GameWindow()
        {
            InitializeComponent();
        }

        public GameWindow(PClass pClass)
        {
            Character = new Person(pClass);
        }
    }
}
