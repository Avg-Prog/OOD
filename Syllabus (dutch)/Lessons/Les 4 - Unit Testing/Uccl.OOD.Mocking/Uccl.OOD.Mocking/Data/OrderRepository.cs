using Dapper;
using Microsoft.Data.Sqlite;
using Uccl.OOD.Mocking.Data.DTO;

namespace Uccl.OOD.Mocking.Data;

public class OrderRepository : IOrderRepository
{
    private readonly ILogger _logger;
    private readonly string _connectionString;
    public OrderRepository(ILogger<OrderRepository> logger, IConfiguration configuration)
    {
        _logger = logger;
        _connectionString = configuration.GetConnectionString("MyDatabase");
    }
    public List<Order> ForCustomer(int customerId)
    {
        using var connection = new SqliteConnection(_connectionString);

        try
        {
            connection.Open();

            return connection
                .Query<Order>("SELECT * FROM [Orders] WHERE CustomerID = @customerId", new { @customerId  = customerId})
                .ToList();
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, "Error with getting costumers from database");
            throw;
        }
    }

    public List<Order> GetAll()
    {
        using var connection = new SqliteConnection(_connectionString);

        try
        {
            connection.Open();

            return connection
                .Query<Order>("SELECT * FROM [Orders]")
                .ToList();
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, "Error with getting costumers from database");
            throw;
        }
    }
}
