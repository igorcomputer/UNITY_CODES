using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid.lsp_bad {
    public interface IUnit {
        public void Move();
        public void Heal();
        public void Attack();
    }

    public class UnitArcher : IUnit {
        public void Move() { }
        public void Heal() { }
        public void Attack() { }
    }

    // Попытались сделать Мирного Юнита и пришлось переопределять метод (делать пустым)
    // В дальнейшем при использовании объекта класса мы получим не правильное поведение 
    // - это лечится создание доп.  интерфейса см. файл "good_lsp.cs"
    public class UnitCitizen : IUnit {
        public void Move() { }
        public void Heal() { }
        public void Attack() { 
            throw new NotImplementedException();
        }
    }
}
