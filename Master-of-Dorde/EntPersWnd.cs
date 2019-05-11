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
        bool MageClassBtnActive, BerserkClassBtnActive, WarriorClassBtnActive;

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

        private void MageClassBtn_MouseEnter(object sender, EventArgs e)
        {
            MageClassBtn.BackgroundImage = Engine.Resources.MageClassBtn_Hover;
        }

        private void EntPersWnd_Load(object sender, EventArgs e)
        {
            MageClassBtn.BackgroundImage = Engine.Resources.MageClassBtn_Passive;
            WarriorClassBtn.BackgroundImage = Engine.Resources.WarriorClassBtn_Passive;
            BerserkClassBtn.BackgroundImage = Engine.Resources.BerserkClassBtn_Passive;
            StatImage.BackgroundImage = Resources.Bckgrnd_Dark;
        }

        private void MageClassBtn_MouseLeave(object sender, EventArgs e)
        {
            MageClassBtn.BackgroundImage = Engine.Resources.MageClassBtn_Passive;
        }

        private void WarriorClassBtn_MouseEnter(object sender, EventArgs e)
        {
            WarriorClassBtn.BackgroundImage = Engine.Resources.WarriorClassBtn_Hover;
        }

        private void WarriorClassBtn_MouseLeave(object sender, EventArgs e)
        {
            WarriorClassBtn.BackgroundImage = Engine.Resources.WarriorClassBtn_Passive;
        }

        private void BerserkClassBtn_MouseEnter(object sender, EventArgs e)
        {
            BerserkClassBtn.BackgroundImage = Engine.Resources.BerserkClassBtn_Hover;
        }

        private void BerserkClassBtn_MouseLeave(object sender, EventArgs e)
        {
            BerserkClassBtn.BackgroundImage = Engine.Resources.BerserkClassBtn_Passive;
        }

        private void MageClassBtn_Click(object sender, EventArgs e)
        {
            StatImage.BackgroundImage = Resources.MageStat_Complete;
            MageClassBtnActive    = true;
            WarriorClassBtnActive = false;
            BerserkClassBtnActive = false;
        }

        private void WarriorClassBtn_Click(object sender, EventArgs e)
        {
            StatImage.BackgroundImage = Resources.WarriorStat_Complete;
            MageClassBtnActive    = false;
            WarriorClassBtnActive = true;
            BerserkClassBtnActive = false;
        }

        private void BerserkClassBtn_Click(object sender, EventArgs e)
        {
            StatImage.BackgroundImage = Resources.BerserkStat_Complete;
            MageClassBtnActive    = false;
            WarriorClassBtnActive = false;
            BerserkClassBtnActive = true;
        }
    }
}
