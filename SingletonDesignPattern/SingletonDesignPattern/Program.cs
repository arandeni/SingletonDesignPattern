// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using SingletonDesignPattern;

Singleton instance1 = Singleton.Instance;
Singleton instance2 = Singleton.GetInstance();

Logger _logger = Logger.Instance;
_logger.LogMessage("Test log");

DbConnection conn = DbConnection.GetDbConn();
conn.ConnectionString = "";
conn.RunQuery("Select * from employee");