using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_of_Dorde.Engine
{
    class Person
    {
        public PClass pClass;
        public int Health, Mana, Armor;
        public int maxHealth, maxMana, maxArmor;

        public int IF1, IF2;      // Impact Force (Сила удара)


        public Person(PClass pClass)
        {
            switch (pClass)
            {
                case PClass.PC_WARRIOR:
                    maxHealth = 100;
                    maxMana = 20;
                    maxArmor = 130;
                    IF1 = 30;
                    IF2 = 60;
                    break;

                case PClass.PC_MAGE:
                    maxHealth = 90;
                    maxMana = 130;
                    maxArmor = 30;
                    IF1 = 60;
                    IF2 = 10;
                    break;

                case PClass.PC_BERSERK:
                    maxHealth = 130;
                    maxMana = 30;
                    maxArmor = 90;
                    IF1 = 60;
                    IF2 = 20;
                    break;

                default:
                    break;
            }

            Health = maxHealth;
            Mana = maxMana;
            Armor = maxArmor;

        }
    }
}