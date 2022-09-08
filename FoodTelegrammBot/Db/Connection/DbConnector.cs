namespace FoodTelegrammBot.Db.Connection;
using Npgsql;

public class DbConnector
{
    private static DbConnector _connector = null;
    
    private const string connectionString = 
        "Host=194.67.105.79;Username=mybestbotuser;Password=679;Database=mybestbotdb";
    
    
    public NpgsqlConnection Connection { private set; get; }

    private DbConnector()
    {
        Connection = new NpgsqlConnection(connectionString);
        Connection.Open();
    }

    public static DbConnector GetInstance()
    {
        if (_connector == null)
        {
            _connector = new DbConnector();
        }

        return _connector;
    }
}