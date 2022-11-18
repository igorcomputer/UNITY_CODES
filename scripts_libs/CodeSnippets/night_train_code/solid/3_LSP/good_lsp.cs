using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid.lsp_good {
    public interface IUnit {
        public void Move();
        public void Heal();
    }

    public interface IUnitWarrior: IUnit {
        public void Attack();
    }

    public class UnitArcher : IUnitWarrior {
        public void Move() { }
        public void Heal() { }
        public void Attack() { }
    }

    public class UnitCitizen : IUnit {

        public void Heal() { }
        public void Move() { }
    }
}
