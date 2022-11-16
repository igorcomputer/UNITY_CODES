/*

И тут мы захотели иметь разные реализации оружия:

Бесконечный пистолет;
Лук, у которого с каждым выстрелом уменьшается урон.

И тут мы захотели иметь разные реализации оружия:

- Бесконечный пистолет;
- Лук, у которого с каждым выстрелом уменьшается урон.

Как мы можем это выразить? На самом деле просто. 
И, я думаю, вы бы с лёгкостью с этим справились. 
Но я добавлю ещё одно условие: нужно сделать такое оружие, 
и при этом, чтобы алгоритм симуляции боя и какие-нибудь другие 
части программы не изменялись. Т.е. хотелось бы работать с этим извне, 
на уровне конфигурации, и не переписывать код каждый раз, когда нам добавляется оружие.

Мы можем удовлетворить условие с помощью виртуальных методов. 
Мы можем пометить метод Fire в базовый класс модификатором virtual, 
а в производных классах сделать точно такие же методы по сигнатуре, 
но с модификатором override.

Damage стал protected для того, чтобы производные классы могли его изменить;
В классе Bow мы используем строку, которая вызывает метод базового класса. 
В случае с Pistol мы полностью переопределяем код. 
Т.е. метод Fire базового класса не выполнится. 
А вот в случае с Bow мы вызываем метод базового класса 
и добавляем ему дополнительное поведение (уменьшение урона в два раза).

*/

namespace example_002 {
    class Program {
        static void Main(string[] args) {
            Gun gun = new Gun();
            Player player1 = new Player();
            gun.Fire(player1);

            gun = new Bow();
            gun.Fire(player1);
            gun.Fire(player1);

            Battle battle = new Battle(new Pistol(), new Player[] { player1 });
            battle.Simulate();
        }
    }

    class Battle {
        private Gun _gun;
        private Player[] _players;

        public Battle(Gun gun, Player[] players) {
            _gun = gun;
            _players = players;
        }

        public void Simulate() {
            foreach (var player in _players) {
                _gun.Fire(player);
            }
        }
    }

    class Player {
        private float _health;

        public void ApplyDamage(float amount) {
            _health -= amount;
        }
    }

    class Gun {
        private int _bullets;
        protected float Damage;

        public virtual void Fire(Player player) {
            if (_bullets <= 0)
                return;

            player.ApplyDamage(Damage);
            _bullets--;
        }
    }

    class Pistol : Gun {
        public override void Fire(Player player) {
            player.ApplyDamage(Damage);
        }
    }

    class Bow : Gun {
        public override void Fire(Player player) {
            base.Fire(player);
            Damage /= 2;
        }
    }
}