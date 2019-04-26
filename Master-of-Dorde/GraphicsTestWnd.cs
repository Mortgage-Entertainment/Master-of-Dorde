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
        }
    }
}
