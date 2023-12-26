// See https://aka.ms/new-console-template for more information
using MySql.Data.MySqlClient;

Console.WriteLine("Hello, Welcome to my Datbase Connection!");
MySqlConnection conn=new MySqlConnection();
conn.ConnectionString="server=192.168.10.150;port=3306;user=dac6;password=welcome;database=dac6";
string query="select * from student";
string quer=" insert into student (id,namefirst,namelast) values(130,'A1','C1')";
string updateSql = "UPDATE student SET emailid = @emailid  WHERE namefirst = Atharva";
string deletquer="delete from student where namelast=@A4";
string createquer="create table Dao ( id int, name varchar(30), city varchar(50))";
MySqlCommand comm4=new MySqlCommand(createquer,conn);


MySqlCommand comm2=new MySqlCommand(deletquer,conn);
comm2.Parameters.AddWithValue("@A4","Atharva");

// System.Console.WriteLine(deletquer);
MySqlCommand comm1=new MySqlCommand(updateSql,conn);

comm1.Parameters.AddWithValue("@emailid", "atharvachothave3@gmail.com");
try{
conn.Open();
comm2.ExecuteNonQuery();
Console.WriteLine("Deleted  succesfully...");
comm4.ExecuteNonQuery();
Console.WriteLine("Table created.......");

MySqlCommand command=new MySqlCommand(query,conn);
MySqlDataReader reader=command.ExecuteReader();
while(reader.Read())
{
    int id=int.Parse(reader["id"].ToString());
    string namefirst=reader["namefirst"].ToString();
    string namelast=reader["namelast"].ToString();
    Console.WriteLine(id+"     "+namefirst+"     "+namelast);
}
reader.Close();
  


MySqlCommand comm=new MySqlCommand(quer,conn);
comm.ExecuteNonQuery();
Console.WriteLine("Entry inserted ...");

comm1.ExecuteNonQuery();
Console.WriteLine("updated succesfully...");

//
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}
finally
    {
     conn.Close();
    }
// Now inserting Query



