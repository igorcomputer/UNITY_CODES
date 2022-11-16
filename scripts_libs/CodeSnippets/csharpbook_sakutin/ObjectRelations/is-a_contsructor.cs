/*

Is-a  - Наследование  + Цепочки вызовов конструкторов

Когда базовый класс (тот от когда наследуемся) имеет конструктор, 
то мы должны его вызвать в производном классе (тот который наследуется).

Сделать мы можем это с помощь цепочки вызова конструкторов. 
При этом конструктор базового класса вызывается первым.

*/

namespace relation_is_a_constructor {

    class Warrior {
        public int Health;
        public int Armor;

        public Warrior(int health, int armor) {
            Health = health;
            Armor = armor;
        }

        public void TakeDamage(int damage) {
            Health -= damage - Armor;
        }
    }

    class Knight : Warrior {
        public Knight(int health, int armor) : base(health, armor) { }

        public void Pray() {
            Armor += 1;
        }
    }

    class Barbarian : Warrior {
        public int LenghtOfAxe;

        public Barbarian(int health, int armor, int lenghtOfAxe) : base(health, armor) {
            LenghtOfAxe = lenghtOfAxe;
        }

        public void Waaaagh() {
            Health += 10;
            Armor -= 1;
        }
    }

}