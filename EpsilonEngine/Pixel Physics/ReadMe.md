# Pixel Physics

Pixel physics is an open source, pixel perfect, deterministic, multithreaded, axis aligned, 2D, rigidbody, physics simulation engine.

It offers support for user defined coliders made from arrays of pixel perfect rectangles.
It allows for optimization using bounds checks and multithreading.
It promises deterministic physics simulation even with millions of objects in parralel.
It also promises deterministic physics regardless of execution order or race conditions.
It also promises deterministic physics regardless of lag or hardware specs. Although slower systems may result in slower simulations.
It promises hitboxes will never clip into each other regardless of circumstances.
It does not offer support for rotation nor for hitboxes off the pixel grid such as slopes.
It offers support for bounciness, friction, objects pushing each other, one sided collision, collision masks, and objects sticking to moving surfaces.
It also supports trigger zones which cannot be clipped through regardless of speed or tick rate.

It features the following classes:
Simulation - An instance of the physics engine. Everything else depends upon the simulation.
PhysicsObject - An object with a hitbox which can move in the world.
TriggerZone - A trigger zone which logs when physics objects overlap its bounds.
Collision - A class for storing data relating to a collision between two PhysicsObjects.
Overlap - A class for storing data relating to an overlap event of a PhysicsObject and a TriggerZone.
SideInfo - A struct for storing which sides of two PhysicsObjects collided with eachother.