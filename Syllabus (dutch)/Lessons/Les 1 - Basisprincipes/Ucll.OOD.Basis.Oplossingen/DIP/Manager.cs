namespace DIP;

internal class Manager
{
    private List<Employee> employees { get; set; }

    public void AssignEmployee(Employee employee)
    {
        employees.Add(employee);
    }
}
