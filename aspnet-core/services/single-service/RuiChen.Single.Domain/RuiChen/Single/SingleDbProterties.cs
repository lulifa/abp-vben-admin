namespace RuiChen.Single;

public static class SingleDbProterties
{
    public static string DbTablePrefix { get; set; } = "Single_";

    public static string? DbSchema { get; set; } = null;


    public const string ConnectionStringName = "Single";
}
