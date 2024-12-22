using System.Collections.Generic;

namespace EpsilonEngine
{
    public sealed class PhysicsSimulation
    {
        public List<PhysicsObject> _physicsObjects = new List<PhysicsObject>();
        public PhysicsSimulation()
        {

        }
        public void Tick()
        {
            for (int i = 0; i < _physicsObjects.Count; i++)
            {
                _physicsObjects[i].Tick();
                _physicsObjects[i].Draw();
            }
        }
    }
}
