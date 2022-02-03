namespace PublicCNPJ.API.Data;

public class Context
{
    private readonly string connectionString;

    public Context(string connectionString)
    {
        this.connectionString = connectionString;
    }

    public SQLiteConnection GetSQLiteConnection => new SQLiteConnection(connectionString);
}