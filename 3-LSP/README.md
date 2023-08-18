# Liskov Substitution Principle (LSP)

### Bad example:
In this bad example, the **Square** class inherits from the **Rectangle** class, which seems logical because a square is a special case of a rectangle. However, the Square class overrides the **Width** and **Height** properties to maintain the invariant that both sides are equal. 
This violates the Liskov Substitution Principle because substituting a **Square object for a Rectangle object leads to unexpected behavior**. 
For example, changing the height of a Square also changes its width, which contradicts the expected behavior of a Rectangle.

### Good example:
In this good example, the **Shape** class defines an abstract **Area** method that all shapes should implement. The **Rectangle** and **Square** classes both derive from **Shape**, and each provides its own implementation of the Area method. The Square class does not attempt to inherit from Rectangle, as this would violate the Liskov Substitution Principle.
Instead, both Rectangle and Square classes inherit from the common base class Shape.
  
By following the Liskov Substitution Principle, objects of derived classes (Square) should be substitutable for objects of their base classes (Shape) without altering the correctness of the program.