Here are the reflection answers rephrased to sound more natural, conversational, and "human-written" while keeping the technical concepts completely accurate. This style avoids sounding like a textbook copy-paste and feels more like an organic student response.

1. Why did you use inheritance?
We used inheritance—specifically by making Vehicle an abstract class—because there is a clear "IS-A" relationship here. A car, a plane, a boat, and a helicopter are all fundamentally vehicles.

Breaking it down, inheritance helps us with two main things:

No code repetition: Instead of typing out a Name property in every single class, we just write it once in the base Vehicle class and everyone inherits it.

Polymorphism: It lets us bunch all these completely different classes into a single list, like a List<Vehicle>. We can then loop through that list and call .Move() on each item dynamically without the compiler getting confused.

2. Why did you use interfaces?
While inheritance handles what an object is, interfaces handle what an object "CAN DO." They represent behaviors that aren’t tied to just one type of vehicle.

For example, not every vehicle can fly, and not every vehicle can sail. By creating interfaces like IFlyable, IDriveable, and ISailable, we can cleanly hand out specific abilities (like a contract) to whatever class needs them, without messing with their main identity as a Vehicle.

3. Could Helicopter inherit from both Vehicle and Airplane? Why or why not?
No, it can't. In C# (and most modern programming languages), multiple inheritance for classes is strictly forbidden. A class can only have one direct parent.

If C# allowed a class to inherit from two parents, we'd run into a classic coding headache called the Diamond Problem. If both Vehicle and Airplane happened to have different versions of the same method, the compiler wouldn’t know which one the Helicopter is supposed to use. To keep things clean and predictable, Helicopter can only inherit directly from Vehicle.

4. Why can Helicopter implement both IFlyable and IDriveable?
Even though C# doesn't let you inherit from multiple classes, it absolutely lets you implement as many interfaces as you want. This works because interfaces don't actually hold data or "state" (they don't have fields or variables inside them); they are just a checklist of methods that a class promises to build. Because of this, a Helicopter can safely promise to be both flyable (IFlyable) and driveable (IDriveable) at the same time, and the compiler has zero issues with it.

5. If a Submarine can both sail and dive, how would you design it?
I would use the exact same strategy we used for the helicopter—combining inheritance for its identity and multiple interfaces for its behavior:

The Core Identity (IS-A): The Submarine class would inherit from the Vehicle base class because, at the end of the day, it's still a vehicle.

The Behaviors (CAN-DO): It would implement two interfaces: ISailable (since it can move on top of the water) and a new IDiveable interface (since it can submerge).