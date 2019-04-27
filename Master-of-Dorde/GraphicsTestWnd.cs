using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Master_of_Dorde
{
    public partial class GraphicsTestWnd : Form
    {
        public GraphicsTestWnd()
        {
            InitializeComponent();
        }

        private void pictureBox7_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            BtnImg1.BackgroundImage = Engine.Resources.Btn_Grn_Hover;
        }

        private void BtnImg1_MouseLeave(object sender, EventArgs e)
        {
            BtnImg1.BackgroundImage = Engine.Resources.Btn_Grn_Passive;
        }

        private void GraphicsTestWnd_Load(object sender, EventArgs e)
        {
            // Делаем обычный стиль.
            FormBorderStyle = FormBorderStyle.FixedDialog;
            // Убираем кнопки свернуть, развернуть, закрыть.
            ControlBox = false;
            // Убираем заголовок.
            Text = "";

            MainBackgroundPanel.BackgroundImage = Engine.Resources.Bckgrnd_Dark;
            RightPanel.BackgroundImage      = Engine.Resources.Bckgrnd_Panel_White;
            MageClassBtn.BackgroundImage    = Engine.Resources.MageClassBtn_Passive;
            WarriorClassBtn.BackgroundImage = Engine.Resources.WarriorClassBtn_Passive;
            BerserkClassBtn.BackgroundImage = Engine.Resources.BerserkClassBtn_Passive;
            SpriteBox.BackColor = BackColor;
        }

        private void BtnImg1_Click(object sender, EventArgs e)
        {

        }

        private void MageClassBtn_MouseEnter(object sender, EventArgs e)
        {
            MageClassBtn.BackgroundImage = Engine.Resources.MageClassBtn_Hover;
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
            SpriteBox.BackgroundImage = Engine.Resources.Mage_Sprite;
            InfBox.BackgroundImage = Engine.Resources.Mage_Stat;
        }

        private void WarriorClassBtn_Click(object sender, EventArgs e)
        {
            SpriteBox.BackgroundImage = Engine.Resources.Warrior_Sprite;
            InfBox.BackgroundImage = Engine.Resources.Warrior_Stat;
        }

        private void BerserkClassBtn_Click(object sender, EventArgs e)
        {
            SpriteBox.BackgroundImage = Engine.Resources.Berserk_Sprite;
            InfBox.BackgroundImage = Engine.Resources.Berserk_Stat;
        }
    }
}
