1. Why did you use inheritance?
We used inheritance because cars, airplanes, boats, and helicopters share a clear "IS-A" relationship with the abstract Vehicle class. This lets us share common code like the Name property and group different vehicles into a single List<Vehicle> to trigger their Move() methods dynamically using polymorphism.

2. Why did you use interfaces?
We used interfaces to define "CAN-DO" behaviors like flying, driving, or sailing, which aren't limited to just one specific family of vehicles. Interfaces like IFlyable, IDriveable, and ISailable act as clean code contracts that add specific capabilities to a class without messing up its core identity as a vehicle.

3. Could Helicopter inherit from both Vehicle and Airplane? Why or why not?
No, because C# strictly forbids multiple class inheritance to avoid a compiler conflict known as the "Diamond Problem." If both parent classes had different logic for the same method, the compiler wouldn't know which one to use, which is why Helicopter can only inherit directly from Vehicle.

4. Why can Helicopter implement both IFlyable and IDriveable?
While C# blocks multiple class inheritance, it completely allows a class to implement multiple interfaces. This works because interfaces don't store data or state that could cause logical collisions; they are just checklists of methods, allowing the Helicopter to safely fulfill both the flying and driving contracts at the same time.

5. If a Submarine can both sail and dive, how would you design it?
I would design it just like the helicopter by inheriting from Vehicle for its core identity, while implementing multiple interfaces for its behavior. Specifically, the Submarine class would implement the existing ISailable interface for surface movement and a new IDiveable interface for submerging underwater.