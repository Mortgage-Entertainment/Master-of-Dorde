namespace Master_of_Dorde.Engine
{
    class Person
    {
        // Класс мобов

        public PClass pClass;
        public int Health, Mana, Armor;
        public int maxHealth, maxMana, maxArmor;    // Максимально возможные значения

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
                    this.pClass = PClass.PC_WARRIOR;
                    break;

                case PClass.PC_MAGE:
                    maxHealth = 90;
                    maxMana = 130;
                    maxArmor = 30;
                    IF1 = 60;
                    IF2 = 10;
                    this.pClass = PClass.PC_MAGE;
                    break;

                case PClass.PC_BERSERK:
                    maxHealth = 130;
                    maxMana = 30;
                    maxArmor = 90;
                    IF1 = 60;
                    IF2 = 20;
                    this.pClass = PClass.PC_BERSERK;
                    break;

                default:
                    break;
            }

            // Устанавливаем все на максимум в начале игры
            Health = maxHealth;
            Mana = maxMana;
            Armor = maxArmor;
        }
    }
}