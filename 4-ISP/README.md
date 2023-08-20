# Interface Segregation Principle (ISP)

### Bad example:
In this bad example, the **IUser** interface combines multiple methods, including actions related to authentication (**Login and Logout**), user interactions (**ViewDashboard**), and even unrelated actions like sending emails and uploading files. 
If a class implements this interface, it will be forced to provide implementations for all these methods, even if it doesn't need all of them.

### Good example:
In this good example, each interface represents a specific role or capability of a user. Classes representing different user roles can implement only the interfaces that are relevant to them, and there's no need to implement unnecessary methods. 

This adheres to the Interface Segregation Principle, promoting smaller and more focused interfaces based on user roles or capabilities.