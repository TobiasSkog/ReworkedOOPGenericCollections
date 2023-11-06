using ReworkedOOPGenericCollections.Logic.EmployeeVariants;

namespace ReworkedOOPGenericCollections.Logic
{
    public static class CreateEmployeeArrays
    {
        public static Employee[] EmployeeListArray()
        {

            Employee[] employeeArray = new[]
            {
                new EmployeeList("Anas", Gender.Male, 50000),
                new EmployeeList("Hanna", Gender.Female, 40000),
                new EmployeeList("Tobias", Gender.Male, 40000),
                new EmployeeList("Sara", Gender.Female, 30000),
                new EmployeeList("Anna", Gender.Female, 20000),
            };
            return employeeArray;
        }
        public static Employee[] EmployeeStackArray()
        {
            Employee[] employeeArray = new[]
            {
                new EmployeeStack("Anas", Gender.Male, 50000),
                new EmployeeStack("Hanna", Gender.Female, 40000),
                new EmployeeStack("Tobias", Gender.Male, 40000),
                new EmployeeStack("Sara", Gender.Female, 30000),
                new EmployeeStack("Anna", Gender.Female, 20000),
            };
            return employeeArray;
        }
    }
    public class EmployeeSpecificLogic
    {
        public static Stack<Employee> AddEmployeesToStack(Employee[] employees)
        {
            Console.WriteLine($"Adding employees to Stack\n");

            Stack<Employee> employeeStack = new();
            for (int i = 0; i < employees.Length; i++)
            {
                employeeStack.Push(employees[i]);
            }

            return employeeStack;
        }

        public static List<Employee> AddEmployeesToList(Employee[] employees)
        {
            Console.WriteLine($"Adding employees to List\n");

            List<Employee> employeeList = new();
            for (int i = 0; i < employees.Length; i++)
            {
                employeeList.Add(employees[i]);
            }

            return employeeList;
        }

        public static void PrintAllEmployeesInStack(Stack<Employee> employees)
        {
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
                Console.WriteLine($"Items left in the Stack = {employees.Count}");
            }
        }

        public static void PopEmployeesInStack(Stack<Employee> employees)
        {
            Console.WriteLine("Retrieve Using PoP Method\n");
            int employeesLength = employees.Count;
            for (int i = 0; i < employeesLength; i++)
            {
                Console.WriteLine(employees.Pop());
                Console.WriteLine($"Items left in the Stack = {employees.Count}");
            }
        }

        public static void PeekEmployeesInStack(Stack<Employee> employees, int timesToPeek)
        {
            Console.WriteLine("Retrieve Using Peek Method\n");
            for (int i = 0; i < timesToPeek; i++)
            {
                Console.WriteLine(employees.Peek());
                Console.WriteLine($"Items left in the Stack = {employees.Count}");
            }
        }

        public static bool FindEmployeeInStack(Stack<Employee> employees, Employee specificEmployee)
        {
            return employees.Contains(specificEmployee);
        }

        public static bool ListContainsSpecificEmployee(List<Employee> employees, Employee specificEmployee)
        {
            return employees.Contains(specificEmployee);
        }

        public static void FindFirstGenderInList(List<Employee> list, Gender targetGender)
        {
            Console.WriteLine($"Finding first Employee object with the gender: \"{targetGender}\" in the List of employees\n");

            if (list.Count > 0 && list.Exists(employee => employee.Gender == targetGender))
            {
                var employee = list.Find(employee => employee.Gender == targetGender);
                Console.WriteLine(employee);
            }
            else
            {
                Console.WriteLine($"List did not contain \"{targetGender}\".");
            }
        }

        public static void FindAllGendersInList(List<Employee> list, Gender targetGender)
        {
            Console.WriteLine($"Finding all Employee objects with the gender: \"{targetGender}\" in the List of employees\n");

            if (list.Count > 0 && list.Exists(employee => employee.Gender == targetGender))
            {
                list.ForEach(employee =>
                {

                    if (employee.Gender == targetGender)
                    {
                        Console.WriteLine(employee);
                    }
                });
            }
            else
            {
                Console.WriteLine($"List did not contain \"{targetGender}\".");
            }
        }
    }
}
