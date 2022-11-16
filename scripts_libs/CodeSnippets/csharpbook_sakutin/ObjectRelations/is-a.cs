/*

Is-a  - Наследование 

Это удобно когда мы имеем несколько классов у 
которых есть нечто общее. 

При этом собрать все классы в один мы не можем. 
*/

namespace relation_is_a {

    class Knight {
        public int Health;
        public int Armor;

        public void TakeDamage(int damage) {
            Health -= damage - Armor;
        }

        public void Pray() {
            Armor += 1;
        }
    }

    class Barbarian {
        public int Health;
        public int Armor;

        public void TakeDamage(int damage) {
            Health -= damage - Armor;
        }

        public void Waaaagh() {
            Health += 10;
            Armor -= 1;
        }
    }

}