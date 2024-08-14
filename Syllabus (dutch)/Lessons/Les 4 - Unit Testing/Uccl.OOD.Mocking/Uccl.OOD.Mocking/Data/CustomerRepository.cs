using Microsoft.Data.Sqlite;
using Dapper;
using Uccl.OOD.Mocking.Data.DTO;
using Uccl.OOD.Mocking.Data;

namespace Uccl.OOD.Mocking;

public class CustomerRepository : ICustomerRepository
{
    private readonly ILogger _logger;
    private readonly string _connectionString;
    public CustomerRepository(ILogger<CustomerRepository> logger, IConfiguration configuration)
    {
        _logger = logger;
        _connectionString = configuration.GetConnectionString("MyDatabase");
    }

    public Customer? GetCustomerById(int id)
    {
        using var connection = new SqliteConnection(_connectionString);

        try
        {
            connection.Open();

            return connection
                .QuerySingle<Customer>("SELECT * FROM [Customers] WHERE Id = @Id", new { @Id = id });
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, "Error with getting costumers from database");
            throw;
        }
    }

    public List<Customer> GetCustomers()
    {
        using var connection = new SqliteConnection(_connectionString);

        try
        {
            connection.Open();

            return connection
                .Query<Customer>("SELECT * FROM [Customers]")
                .ToList();
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, "Error with getting costumers from database");
            throw;
        }
    }
}
