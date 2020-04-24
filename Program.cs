using System;
using System.Data;
using System.Data.SqlClient;

namespace MyConsoleApp
{
    class Program
    {
        static void SelectAll()
        {
            const string connectionString = @"Data source=AZAMOT; Initial catalog=AlifAcademy;Integrated Security = True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM Person";
            command.Connection = connection;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                System.Console.WriteLine($"Id :{reader.GetValue("Id")},\tLastName :{reader.GetValue("LastName")},\tFirstName :{reader.GetValue("FirstName")},\tMiddleName : {reader.GetValue("MiddleName")},\tBirthDate: {reader.GetValue("BirthDate")}");
            }
            connection.Close();
        }
        static void SelectById(string Id)
        {
            const string connectionString = @"Data source=AZAMOT; Initial catalog=AlifAcademy;Integrated Security = True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM Person";
            command.Connection = connection;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetValue(0).ToString() == Id)
                    System.Console.WriteLine($"Id {reader.GetValue("Id")},LastName:{reader.GetValue("LastName")},FirstName:{reader.GetValue("FirstName")},MiddleName:{reader.GetValue("MiddleName")},BirthDate:{reader.GetValue("BirthDate")}");
            }
            connection.Close();
        }

        static void Insert()
        {
            const string connectionString = @"Data source=AZAMOT; Initial catalog=AlifAcademy;Integrated Security = True";
            string sqlExpression = "INSERT INTO Person (Id,LastName,FirstName,MiddleName,BirthDate) Values(4,'Khaidarov','Azamat','Firdavsi',2001-27-02)";

            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            SqlCommand command1 = new SqlCommand(sqlExpression, connection);
            int number = command1.ExecuteNonQuery();
            Console.WriteLine($"Добавлен Элемент {number}");
            connection.Close();
        }

        static void Update()
        {
            const string connectionString = @"Data source=AZAMOT; Initial catalog=AlifAcademy;Integrated Security = True";
            string sqlExpression = "UPDATE Person SET BirthDate = 1998-02-27 WHERE LastName = 'Khaidarov'";

            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            int number = command.ExecuteNonQuery();
            Console.WriteLine($"Обновлен элемент{number}");
            connection.Close();
        }

        static void Delete()
        {
            const string connectionString = @"Data source=AZAMOT; Initial catalog=AlifAcademy;Integrated Security = True";
            string sqlExpression = "DELETE FROM Person WHERE LastName = 'Khaidarov'";

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            int number = command.ExecuteNonQuery();
            Console.WriteLine($"Удаление объекта{number}");
            connection.Close();
        }


        static void Main()
        {
            Console.WriteLine("Adding : 1");
            Console.WriteLine("Select All : 2");
            Console.WriteLine("Select by Id : 3");
            Console.WriteLine("Update : 4");
            Console.WriteLine("Delete : 5");

            string choise = Console.ReadLine();

            switch (choise)
            {
                case 1:
                    {
                        Console.Write("Enter Name:");
                        string Name = Console.ReadLine();
                        Console.Write("Enter Surname:");
                        string Surname = Console.ReadLine();
                        Console.Write("Enter MiddleName:");
                        string MiddleName = Console.ReadLine();
                        Insert(Name, Surname, MiddleName);

                    }
                case 2:
                    {
                        SelectAll();
                    }

                default:
            }

        }

    }

}









