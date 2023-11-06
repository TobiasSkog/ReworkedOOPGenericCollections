using ReworkedOOPGenericCollections.Logic;
using ReworkedOOPGenericCollections.Logic.EmployeeVariants;

namespace ReworkedOOPGenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            // Creating and initializing two arrays that references the Employee class but is a subclass of Employee
            // to solve the issue of printing in different formats using Generics and overriding ToString.
            // You could probably use the IFormattable interface to get the same functionality without having to use
            // inheritance and polymorphism but I have not tried that method yet.

            Employee[] employeesToFillStackWith = CreateEmployeeArrays.EmployeeStackArray();
            Employee[] employeesToFillListWith = CreateEmployeeArrays.EmployeeListArray();

            Console.WriteLine("~~ Doing Each Part Twice ~~");
            Console.WriteLine("First time we will be using logic that knows of the Employee Class\n" +
                "the second time we will be using Generics methods only\n\n");


            Console.WriteLine("-- Employee Specific Methods --");
            Console.WriteLine("\n    ~~~ Part 1 ~~~\n");

            // Retrieving a Stack of Employee with the same objects from our array of Employee
            Stack<Employee> employeeStack = EmployeeSpecificLogic.AddEmployeesToStack(employeesToFillStackWith);

            // Printing out all the Employee objects in the stack using a foreach loop
            EmployeeSpecificLogic.PrintAllEmployeesInStack(employeeStack);
            Console.WriteLine("------------------------------");

            // Printing out all the Employee objects in the stack using Pop()
            EmployeeSpecificLogic.PopEmployeesInStack(employeeStack);
            Console.WriteLine("------------------------------");

            // Refilling our Stack since we emptied it after printing it using the Pop() method
            employeeStack = EmployeeSpecificLogic.AddEmployeesToStack(employeesToFillStackWith);

            // Printing to the console the top object in our stack, two times using Peek()
            EmployeeSpecificLogic.PeekEmployeesInStack(employeeStack, 2);
            Console.WriteLine("------------------------------");

            // Retrieving a boolean if we found a specific object in the Stack
            bool foundEmployeeNumberThree = EmployeeSpecificLogic.FindEmployeeInStack(employeeStack, employeesToFillStackWith[2]);

            // Depending on IF our bool is true or false we write a specific answer to the console
            Console.WriteLine(foundEmployeeNumberThree ? "Emp3 is in stack" : "Emp3 is not in stack");
            Console.WriteLine("------------------------------");

            Console.WriteLine("\n    ~~~ Part 2 ~~~\n");

            // Retrieving a List of Employee with the same objects from our array of Employee
            List<Employee> employeeList = EmployeeSpecificLogic.AddEmployeesToList(employeesToFillListWith);

            // Retrieving a boolean if we found a specific object in the List
            bool foundEmployeeNumberTwo = EmployeeSpecificLogic.ListContainsSpecificEmployee(employeeList, employeesToFillListWith[1]);

            // Depending on IF our bool is true or false we write a specific answer to the console
            Console.WriteLine(foundEmployeeNumberTwo ? "Employee2 object exists in the list" : "Employee2 object was not found in the list");
            Console.WriteLine("------------------------------");

            // Printing out the first Employee in our list with the specific Gender.Male enum specified as Gender
            // If we do not find an object in our list with a matching gender we tell the user that
            EmployeeSpecificLogic.FindFirstGenderInList(employeeList, Gender.Male);
            Console.WriteLine("------------------------------");

            // Printing out ALL Employees in our list with the specific Gender.Male enum specified as Gender
            // If we do not find an object in our list with a matching gender we tell the user that
            EmployeeSpecificLogic.FindAllGendersInList(employeeList, Gender.Male);
            Console.WriteLine("------------------------------");

            Console.WriteLine("\n================================================\n");

            // Clearing the Stack and List to be reused in the Generics part of the assignment
            employeeStack.Clear();
            employeeList.Clear();

            Console.WriteLine("-- Generic Methods Only --");
            Console.WriteLine("\n    ~~~ Part 1 ~~~\n");

            employeeStack = GenericLogic.AddObjectsToStack(employeesToFillStackWith);
            GenericLogic.PrintEVeryObjectInStack(employeeStack);
            Console.WriteLine("------------------------------");
            GenericLogic.PopItemsInStack(employeeStack);
            Console.WriteLine("------------------------------");
            employeeStack = GenericLogic.AddObjectsToStack(employeesToFillStackWith);
            GenericLogic.PeekItemsInStack(employeeStack, 2);
            Console.WriteLine("------------------------------");
            foundEmployeeNumberThree = GenericLogic.FindObjectInStack(employeeStack, employeesToFillStackWith[2]);
            Console.WriteLine(foundEmployeeNumberThree ? "Emp3 is in stack" : "Emp3 is not in stack");
            Console.WriteLine("------------------------------");
            Console.WriteLine("\n    ~~~ Part 2 ~~~\n");

            employeeList = GenericLogic.AddObjectsToList(employeesToFillListWith);
            foundEmployeeNumberTwo = GenericLogic.ListContainsSpecificObject(employeeList, employeesToFillListWith[1]);
            Console.WriteLine(foundEmployeeNumberTwo ? "Employee2 object exists in the list" : "Employee2 object was not found in the list");
            Console.WriteLine("------------------------------");
            GenericLogic.FindFirstObjectInListWithEnumValue(employeeList, Gender.Male);
            Console.WriteLine("------------------------------");
            GenericLogic.FindAllObjectsInListWithEnumValue(employeeList, Gender.Male);
            Console.WriteLine("------------------------------");

        }
    }
}