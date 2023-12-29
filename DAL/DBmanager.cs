namespace DAL;
using BOL;
using MySql.Data.MySqlClient;

public static class DBmanager
{    
    
    public static List<Students>GetStudents()
    {  MySqlConnection conn = new MySqlConnection();
      
       conn.ConnectionString ="server=localhost;user=root;password=admin;database=mysql";
       List<Students> li = new List<Students>();
       
        
        string query = "select ID, namefirst,namelast from Student";

        try
        {
            MySqlCommand comm1 = new MySqlCommand(query, conn);
            conn.Open();
            MySqlDataReader reader = comm1.ExecuteReader();
            while (reader.Read())
            {
                int ID = int.Parse(reader["ID"].ToString());
                string Name = reader["namefirst"].ToString();
                string NamLast=reader["namelast"].ToString();
                Students s1 = new Students(ID,Name,NamLast);
             
                li.Add(s1);
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
    
    
     public static List<Students>studentid()
    {   
         MySqlConnection conn2 = new MySqlConnection();
      
         conn2.ConnectionString ="server=localhost;user=root;password=admin;database=mysql";
         List<Students> li = new List<Students>();
         
        string query = "select ID, namefirst,namelast from Student where Id=2";
       try
        {
            MySqlCommand comm2 = new MySqlCommand(query, conn2);
            conn2.Open();
            MySqlDataReader reader = comm2.ExecuteReader();
            while (reader.Read())
            {
                int ID = int.Parse(reader["ID"].ToString());
                string Name = reader["namefirst"].ToString();
                string NamLast=reader["namelast"].ToString();
                
                Students s2 = new Students(ID,Name,NamLast);
             
                li.Add(s2);
            }

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            conn2.Close();
        }
        return li;
    }

      public static List<Students>studentq()
    {   
         MySqlConnection conn1 = new MySqlConnection();
      
         conn1.ConnectionString ="server=localhost;user=root;password=admin;database=mysql";
         List<Students> li = new List<Students>();
         
        string query = "select ID, name,college,university from Student_qualifications";
       try
        {
            MySqlCommand comm2 = new MySqlCommand(query, conn1);
            conn1.Open();
            MySqlDataReader reader = comm2.ExecuteReader();
            while (reader.Read())
            {
                int ID = int.Parse(reader["ID"].ToString());
                string Name = reader["name"].ToString();
                string NamLast=reader["college"].ToString();
                string University=reader["university"].ToString();
                
                Students s2 = new Students(ID,Name,NamLast,University);
             
                li.Add(s2);
            }

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            conn1.Close();
        }
        return li;
    }
 public static void AddStudent( string nm,string em)
 {
       MySqlConnection conn1 = new MySqlConnection();
      
       conn1.ConnectionString ="server=localhost;user=root;password=admin;database=mysql";
       string query= "insert into register (Name,Email) values(@n,@e)";
        conn1.Open();
        MySqlCommand comm4=new MySqlCommand(query,conn1);
      
       comm4.Parameters.AddWithValue("@n", nm);
       comm4.Parameters.AddWithValue("@e", em);
       comm4.ExecuteNonQuery();
       conn1.Close();
 }
 public static List<Valid>ValidateUser()
 {     MySqlConnection conn1 = new MySqlConnection();
       conn1.ConnectionString ="server=localhost;user=root;password=admin;database=mysql";
        string query = "select * from Login";
        List<Valid> li = new List<Valid>();
       try
        {
            MySqlCommand comm2 = new MySqlCommand(query, conn1);
            conn1.Open();
            MySqlDataReader reader = comm2.ExecuteReader();
            while (reader.Read())
            {
              
                string email = reader["emailid"].ToString();
                string password=reader["password"].ToString();
                
                Valid v2 = new Valid(email,password);
             
                li.Add(v2);
            }

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            conn1.Close();
        }
        return li;
 }

}
