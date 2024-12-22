using System;
using EpsilonEngine;

namespace Epsilon
{
    public static class Program
    {
        public static PhysicsSimulation physicsSimulation;
        public static PhysicsObject test;
        [STAThread]
        public static void Main(string[] args)
        {
            XNAInterface xnaInterface = new XNAInterface(Update);

            physicsSimulation = new PhysicsSimulation();
            test = new PhysicsObject(physicsSimulation);
            test._xnaInterface = xnaInterface;
            test._texture = xnaInterface.LoadTexture("Image.png");
            test._doubleVelocityX = 0.1;
            test._doubleVelocityY = 0.1;

            xnaInterface.Run();
        }
        public static void Update()
        {
            physicsSimulation.Tick();
        }
    }
}
