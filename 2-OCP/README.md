# Open/Closed Principle (OCP)

### Bad example:
In this bad example, the **DebitInAccount** class contains a Process method that checks the type of account and performs the corresponding proccesing logic. 
If you want to add a new type of account, you need to modify this class, which violates the Open/Closed Principle.

### Good example:
In this good example, **DebitInAccount** defines a Process method that each account class will use to process the debit.
Instead of using inheritance, we are now using extension methods to achieve a similar effect:

* The **DebitInCheckingAccountExtension** class is responsible solely for to debit in checking account.
* The **DebitInSavingAccountExtension** class is responsible solely for to debit in saving account.
  
By following the Open/Closed Principle, you can add new functionality without altering existing code, making your codebase more extensible and easier to maintain.
