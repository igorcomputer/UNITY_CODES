using System;
using UnityEngine;

namespace solid.DIP {
    public interface IInputService {
        public Vector2 GetAxis();
    }

    public class KeyboardInput : IInputService {
        public Vector2 GetAxis() { return default; }
    }

    public class GamepadInput : IInputService {
        public Vector2 GetAxis() { return default; }
    }

    public class MobileInput : IInputService {
        public Vector2 GetAxis() { return default; }
    }

    public class UnitMovement {

        private readonly UnitMovable unitMovable;
        private readonly IInputService inputService;

        public UnitMovement(UnitMovable movable, IInputService service) {
            unitMovable = movable;
            inputService = service; 
        }

        public void MoveByInput() {
            Vector2 direction = inputService.GetAxis();
            unitMovable.Move(direction); 
        }
    }

    public static class InputGlobal { 
        
        private static readonly IInputService Service = new KeyboardInput();
                                                        // OR new MobileInput();
                                                        // OR new GamepadInput();

        public static IInputService GetService() {
            return Service;
        }

        public static Vector2 GetAxis() => Service.GetAxis();
    }

    class Program {

        public void Start() {
            UnitMovable unitMovable = new UnitTransformMovable();
            // IInputService inputService = new MobileInput();

            IInputService inputService = InputGlobal.GetService(); 

            UnitMovement unitMovement = new UnitMovement(unitMovable, inputService);
            unitMovement.MoveByInput();
        }


    }


}
