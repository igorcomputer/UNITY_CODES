using System.Collections;
using System.Collections.Generic;

/*

Часто нам не нужна никакая реализация. В случае с оружием, это не так. 
Нам очевидно, что всё оружие имеет боезапас (кроме пистолета), 
и наносит урон. Но иногда у нас абстракция не имеет никакой реализации (интерфейс) 
или имеет частичную (абстрактный класс с абстрактными методами). 
В обоих случаях нам при наследовании этих типов нужно их полностью реализовать.

Давайте представим, что у нашего игрока есть некоторый инвентарь. 
В нём могут быть размещены самые разные предметы, 
и мы можем с ними взаимодействовать. 
По сути взаимодействие с предметом сводится к тому, что:

Мы помещаем предмет в список предметов в инвентаре.
При помещении предмета в инвентарь, мы оповещаем его об этом.
При выбросе из инвентаря оповещаем об этом.
Решить эту задачу мы можем так:

*/

namespace interface_example_001 {

    class Program {
        static void Main(string[] args) {
            Gun gun = new Bow();
            Player player = new Player();

            player.PickUp(gun);
        }
    }

    interface IInventoryHandler {
        void OnPickup();
        void OnDrop();
    }

    class Gun : IInventoryHandler {

        private int _bullets;
        protected float Damage;

        public virtual void Fire(Player player) {
            if (_bullets <= 0)
                return;

            player.ApplyDamage(Damage);
            _bullets--;
        }

        public void OnPickup() {
            //off scene model
        }

        public void OnDrop() {
            //on scene model
        }
    }

    class Bow : Gun {
        public override void Fire(Player player) {
            base.Fire(player);
            Damage /= 2;
        }
    }

    class Player {
        private float _health;
        private List<IInventoryHandler> _inventory = new List<IInventoryHandler>();

        public void ApplyDamage(float amount) {
            _health -= amount;
        }

        public void PickUp(IInventoryHandler item) {
            _inventory.Add(item);
            item.OnPickup();
        }
    }
}