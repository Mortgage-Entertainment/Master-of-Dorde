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
        private Person Character;    // Переменная игрока
        private Person Enemy;        // Переменная врага

        public GameWindow()
        {
            InitializeComponent();
        }

        public GameWindow(PClass pClass)  // При создании окна принимаем класс будущего игрока
        {
            InitializeComponent();

            Character = new Person(pClass);     // Создаем игрока с ранее полученым классом
            Enemy = new Person(PClass.PC_MAGE); // Создаем противника
            PassingMove.PassAMove(Character);                 // Передаем ход ( выполняем атаку противника )
            DataUpdate();  // Обновляем информацию
        }

        private void DataUpdate() 
        {
            // Метод, обновляющий информацию

            // Обновляем информацию игрока
            PersHealthIndicatorLbl.Text = Convert.ToString(Character.Health);
            PersArmorIndicatorLbl.Text = Convert.ToString(Character.Armor);
            PersManaIndicatorLbl.Text = Convert.ToString(Character.Mana);

            // Обновляем информацию противника
            EnemyHealthIndicatorLbl.Text = Convert.ToString(Enemy.Health);
            EnemyArmorIndicatorLbl.Text = Convert.ToString(Enemy.Armor);
            EnemyManaIndicatorLbl.Text = Convert.ToString(Enemy.Mana);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Enemy = Logic.Impact(Enemy, Character.IF1);       // Враг получает урон
            PassingMove.PassAMove(Character);                 // Передаем ход ( выполняем атаку противника )
            DataUpdate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Enemy = Logic.Impact(Enemy, Character.IF2);       // Враг получает урон
            PassingMove.PassAMove(Character);                 // Передаем ход ( выполняем атаку противника )
            DataUpdate();
        }
    }
}
