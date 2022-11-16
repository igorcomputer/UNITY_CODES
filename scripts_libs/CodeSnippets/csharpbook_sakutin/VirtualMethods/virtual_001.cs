
/*
 
У нас есть некое оружие, которое стреляет в игрока. 
Оружие наносит игроку урон и отсчитывает патроны. 
Также у нас есть правило – оружие без патронов не стреляет.

Всё использование оружия заключено в методе Main. 
Но оружие может пользоваться, и какой-то тип, 
который может симулировать бой. 
 
 */


namespace example_001 {
    class Program {
        static void Main(string[] args) {
            Gun gun = new Gun();
            Player player1 = new Player();
            gun.Fire(player1);
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
        private float _damage;

        public void Fire(Player player) {
            if (_bullets <= 0)
                return;

            player.ApplyDamage(_damage);
            _bullets--;
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


}