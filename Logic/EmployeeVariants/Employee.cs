// Tobias Skog - .NET23

namespace ReworkedOOPGenericCollections.Logic.EmployeeVariants
{
    public enum Gender
    {
        Male,
        Female
    }
    public abstract class Employee
    {
        public string Name { get; private set; }
        public Gender Gender { get; private set; }
        public int Id { get; private set; }
        public decimal Salary { get; private set; }
        protected static int ReferenceId = 101;

        public Employee(string name, Gender gender, decimal salary)
        {
            Name = name;
            Gender = gender;
            Salary = salary;
            Id = ReferenceId++;
        }
    }

    public class EmployeeStack : Employee
    {
        public EmployeeStack(string name, Gender gender, decimal salary) : base(name, gender, salary)
        {
            if (ReferenceId > 105)
            {
                ReferenceId = 101;
            }
        }

        public override string ToString()
        {
            return $"{Id} - {Name} - {Gender} - {Salary}";
        }
    }

    public class EmployeeList : Employee
    {
        public EmployeeList(string name, Gender gender, decimal salary) : base(name, gender, salary)
        {
            if (ReferenceId > 105)
            {
                ReferenceId = 101;
            }
        }
        public override string ToString()
        {
            return $"ID = {Id}, Name = {Name}, Gender = {Gender}, Salary = {Salary}";
        }
    }
}
