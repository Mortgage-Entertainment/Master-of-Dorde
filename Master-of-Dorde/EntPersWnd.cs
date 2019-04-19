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
    public partial class EntPersWnd : Form
    {
        public EntPersWnd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameWindow gameWnd = new GameWindow(PClass.PC_MAGE);   // Если игрок выбрал мага создаем окно игры и передаем туда класс мага
            Close();  // закрываем текущее окно
            gameWnd.Show();  // показываем окно игры
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GameWindow gameWnd = new GameWindow(PClass.PC_WARRIOR);  // Если игрок выбрал воина создаем окно игры и передаем туда класс воина
            Close();  // закрываем текущее окно
            gameWnd.Show();  // показываем окно игры
        }

        private void button3_Click(object sender, EventArgs e)
        { 
            GameWindow gameWnd = new GameWindow(PClass.PC_BERSERK);  // Если игрок выбрал берсерка создаем окно игры и передаем туда класс берсерка 
            Close();  // закрываем текущее окно
            gameWnd.Show();  // показываем окно игры
        }
    }
}
