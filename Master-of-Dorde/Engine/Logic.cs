using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Master_of_Dorde.Engine
{
    class Logic
    {
        static public Person Impact(Person person, int IF)     // Принимает персонажа, которому будет нанесен урон и силу удара (IF = impact force)
        {
            // Метод, обрабатывающий удары и прочее получение урона

            person.Health -= IF;    // отнимаем от здоровья игрока силу удара

            if (person.Health <= 0) {
                MessageBox.Show("Противник умер в тилте");
                Application.Exit();
            }
            return person;
        }
    }
}
