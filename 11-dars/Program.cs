namespace _11_dars;

internal class Program
{
    static List<Employee> employees = new List<Employee>();
    static void Main(string[] args)
    {
        Employee employee1 = new Employee()
        {
            EmployeeId = Guid.NewGuid(),
            FirstName = "Hadyatillo",
            LastName = "Ubaydullayev",
            Position = "Backend",
            Age = 21,
        };

    }
    static void AddEmployee(Employee employee)
    {
        employees.Add(employee);
    }
    static void RemoveEmployee(Guid employeeId)
    {
        employees.RemoveAll(e => e.EmployeeId == employeeId);
    }
    static void UpdateEmployee(Guid employeeId, Employee NewEmployee)
    {
        for (int i = 0; i < employees.Count; i++)
        {
            if (employees[i].EmployeeId == employeeId)
            {
                NewEmployee.EmployeeId = employeeId;
                employees[i] = NewEmployee;
                break;
            }
        }
    }

    static void DisplayEmployee()
    {
        foreach (var employee in employees)
        {
            Console.WriteLine($"Employee ID: {employee.EmployeeId}");
            Console.WriteLine($"Question: {question.Text}");
            Console.WriteLine($"A: {employee}");
            Console.WriteLine($"B: {question.B}");
            Console.WriteLine($"C: {question.C}");
            Console.WriteLine($"Correct Answer: {question.Answer}");
            Console.WriteLine();
        }
    }

}
