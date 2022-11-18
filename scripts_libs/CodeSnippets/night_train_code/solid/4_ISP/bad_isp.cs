using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Нарушение принципа Разделения интерфейсов
namespace solid.isp_bad {

    public interface IWeapon {
        public void PerformAttack();
        public void ParformAlternativeAttack();
        public void Reload();
    }

    public class Shotgun : IWeapon {
        public void ParformAlternativeAttack() {}
        public void PerformAttack() {}
        public void Reload() {}
    }
    public class Pistol : IWeapon {
        public void PerformAttack() {} 
        public void ParformAlternativeAttack() { } // Has No alt attack
        public void Reload() {}
    }

    public class Knife : IWeapon {
        public void PerformAttack() {} 
        public void ParformAlternativeAttack() { } // Has No alt attack
        public void Reload() {} // Has No reload 
    }

}
