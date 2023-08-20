# Dependency Inversion Principle (DIP)

Suppose we have a high-level **LightSwitch** class that directly depends on a low-level **ElectricityProvider** class:

### Bad example:
In this bad example, the **LightSwitch** class has a direct dependency on the **ElectricityProvider** class, which violates the Dependency Inversion Principle. 
High-level modules (like **LightSwitch**) should not depend on low-level modules (like **ElectricityProvider**). 
This design makes it hard to change or extend the behavior of the **LightSwitch** class without modifying its code.

### Good example:
In this good example, we introduced an abstraction (an interface) that both high-level and low-level modules depend on

* We introduce the **ISwitchable** interface, which abstracts the behavior of anything that can be switched on and off.
* Both the **ElectricityProvider and LightSwitch** classes depend on the **ISwitchable** interface instead of concrete implementations.
* The **LightSwitch** class can now work with any class that implements **ISwitchable**, allowing us to change the behavior of the switch without modifying the **LightSwitch** code.

By following the Dependency Inversion Principle, we've decoupled the high-level module (**LightSwitch**) from the low-level module (**ElectricityProvider**) through abstraction, making the system more flexible and easier to maintain.