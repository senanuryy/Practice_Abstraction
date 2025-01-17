# Practice_Abstraction

This project demonstrates the concept of **Abstraction** in C# by implementing a simple program to represent employees in a company. Each employee has common attributes such as first name, last name, and department, while their specific tasks vary based on their roles.

## Features

- **Abstract Class**: 
  - The `Employee` class serves as the base abstract class, containing shared properties and an abstract method `Task()` for defining each employee's task.
- **Derived Classes**:
  - `ProjectManager`: Represents a project manager and overrides the `Task()` method.
  - `SoftwareDeveloper`: Represents a software developer and overrides the `Task()` method.
  - `SalesRepresentative`: Represents a sales representative and overrides the `Task()` method.
- **Dynamic Polymorphism**: Employees are created using the base class reference, and their specific `Task()` method is executed at runtime.

## How It Works

1. The `Employee` abstract class defines common properties:
   - `FirstName`: The employee's first name.
   - `LastName`: The employee's last name.
   - `Department`: The department the employee works in.
   - `Task()`: An abstract method to be implemented by derived classes.

2. Each derived class (`ProjectManager`, `SoftwareDeveloper`, `SalesRepresentative`) overrides the `Task()` method to specify the respective role's responsibilities.

3. In the `Main` method:
   - Objects of different roles are created.
   - Their `Task()` method is called to display their responsibilities.
  
## Example Output
![image](https://github.com/user-attachments/assets/c8d70d9c-b904-4b99-a745-07d3d5f700c3)
