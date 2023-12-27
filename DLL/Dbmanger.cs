namespace DLL;

using BOL;
using MySql.Data.MySqlClient;

public class Dbmanger
{


    public static List<Products> FindallProduct()
    {
        List<Products> li = new List<Products>();
        MySqlConnection conn = new MySqlConnection();
        conn.ConnectionString = "server=192.168.10.150;port=3306;user=dac6;password=welcome;database=dac6";
        string query = "select ProductId, ProductName from Products";

        try
        {
            MySqlCommand comm1 = new MySqlCommand(query, conn);
            conn.Open();
            MySqlDataReader reader = comm1.ExecuteReader();
            while (reader.Read())
            {
                int ID = int.Parse(reader["ProductID"].ToString());
                string Name = reader["ProductName"].ToString();
                Products p1 = new Products(ID,Name );
             
                li.Add(p1);
            }

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            conn.Close();
        }
        return li;
    }

}