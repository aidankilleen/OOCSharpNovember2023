using Microsoft.Data.Sqlite;

Console.WriteLine("DB Hello, World!");
SqliteConnection conn;
string connectionString = @"Data Source=C:\work\training\cso\db\oocsharp.db;";
conn = new SqliteConnection(connectionString);
conn.Open();

string sql = "SELECT * FROM members";
SqliteCommand cmd = new SqliteCommand(sql, conn);

//SqliteDataReader rdr = cmd.ExecuteReader();
var rdr = cmd.ExecuteReader();

while (rdr.Read())
{
    string name = rdr.GetString(1);
    Console.WriteLine(name);
}

rdr.Close();
conn.Close();






