using System;

namespace weapon_segregation {

    public interface IWeapon {
        public void PerformAttack();
    }

    public interface IAlternativeAttackWeapon: IWeapon {
        public void ParformAlternativeAttack();
    }

    public interface IReloadWeapon: IWeapon {
        public void Reload();
    }

    public abstract class Shotgun : IAlternativeAttackWeapon, IReloadWeapon {
        public abstract void ParformAlternativeAttack();
        public abstract void PerformAttack();
        public abstract void Reload();
    }
    public abstract class Pistol : IReloadWeapon {
        public abstract void PerformAttack();
        public abstract void Reload();
    }

    public abstract class Knife : IWeapon {
        public abstract void PerformAttack();
    }

}
