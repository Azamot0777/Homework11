using System;
using System.Data;
using System.Data.SqlClient;

namespace Homework11_SQL
{
    class Program
    {
        

        // static void Open ()
        // {
        //     if (hh.State == ConnectionState.Close)
        //     {
        //         hh.Open ();
        //     }
        // }
        static void Insert (string LastName , string FirstName, string MiddleName,string BirthDate)
        {
            const string conString = @"Data source=AZAMOT; Initial catalog=AlifAcademy;Integrated Security = True";
            SqlConnection hh = new SqlConnection (conString);
            hh.Open();
            int y=int.Parse (BirthDate.Substring(0,4)),m=int.Parse(BirthDate.Substring(5,2)),d=int.Parse(BirthDate.Substring(8,2));
            SqlCommand yy = new SqlCommand ("Insert into Person([LastName],[FirstName],[MiddleName],[BirthDate]) Values ('"+LastName+"','"+FirstName+"','"+MiddleName+"',DATETIMEFROMFORMAT("+y +","+m+","+d+",1,1,1,1))",hh);
            yy.ExecuteNonQuery();
        }

        static void SelectAll ()
        {
            const string conString = @"Data source=AZAMOT; Initial catalog=AlifAcademy;Integrated Security = True";
            SqlConnection hh = new SqlConnection (conString);
            hh.Open();
            string commandText = "Select * from Person";
            SqlCommand command = new SqlCommand(commandText, hh);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                System.Console.WriteLine($"Id {reader.GetValue("Id")},LastName:{reader.GetValue("LastName")},FirstName:{reader.GetValue("FirstName")},MiddleName:{reader.GetValue("MiddleName")},BirthDate:{reader.GetValue("BirthDate")}");
            }
            reader.Close();
        }
        static void SelectById (string Id)
        {
            const string conString = @"Data source=AZAMOT; Initial catalog=AlifAcademy;Integrated Security = True";
            SqlConnection hh = new SqlConnection (conString);
            hh.Open();
            string commandText = "Select * from Person";
            SqlCommand command = new SqlCommand(commandText, hh);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if(reader.GetValue(0).ToString() == Id)
                System.Console.WriteLine($"Id {reader.GetValue("Id")},LastName:{reader.GetValue("LastName")},FirstName:{reader.GetValue("FirstName")},MiddleName:{reader.GetValue("MiddleName")},BirthDate:{reader.GetValue("BirthDate")}");
            }
        }
        static void Update ()
        {
            
        }

        static void Delete ()
        {
            
        }
        static void Main(string[] args)
        {   
            SelectAll();
            SelectById("1");
            Console.ReadKey();
        }   
    }
}
