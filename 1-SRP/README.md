# Single Responsibility Principle (SRP)

### Bad example:
In this bad example, the **UserAuthentication** class is responsible for multiple tasks: authenticating users, logging authentication activities, and sending email notifications. This violates the Single Responsibility Principle because the class has more than one reason to change (i.e., if any of these responsibilities change, the class needs to be modified).

### Good example:
In this good example, the responsibilities have been properly separated into different classes:

* The **UserAuthentication** class is responsible solely for authenticating users.
* The **AuthenticationLogger** class is responsible for logging authentication activities.
* The **Register** class is responsible for add users.
  
By adhering to the Single Responsibility Principle, each class has a clear and focused responsibility, making the codebase more maintainable, easier to understand, and less prone to unintended side effects when changes are made.
