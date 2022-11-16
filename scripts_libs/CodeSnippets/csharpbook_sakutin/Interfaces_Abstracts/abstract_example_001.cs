using System.Collections;
using System.Collections.Generic;

/*

Давайте разберём пример, в котором у нас есть башни, 
которые ждут противника в зоне поражения, 
выбирают его как цель и начинают атаку. 

При этом наследники занимаются следующим:

- Определяют можно ли атаковать эту цель;
- Атакуют эту цель.
 
*/

namespace abstract_example_001 {

    abstract class Tower {

        private Player _target;

        public void Update() {

            if (_target == null) {
                foreach (var player in GetClosestPlayers()) {
                    if (CanAttack(player)) {
                        _target = player;
                        break;
                    }
                }
            }

            if (_target != null)
                Attack(_target);
        }

        protected abstract bool CanAttack(Player player);

        protected abstract void Attack(Player player);

        private IEnumerable<Player> GetClosestPlayers() {
            throw new System.NotImplementedException();
        }

    }

    class ArcherTower : Tower {
        protected override void Attack(Player player) {
            player.ApplyDamage(2);
        }

        protected override bool CanAttack(Player player) {
            throw new System.NotImplementedException();
        }
    }

    class Player {
        private float _health;

        public void ApplyDamage(float amount) {
            _health -= amount;
        }
    }

}