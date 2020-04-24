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
        static void SelectById(int number)
        {
            const string conString = @"Data source = AZAMOT; Initial catalog = AlifAcademy; Integrated Security=true";
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            string commandText1 = ($"Select * from Person where id = {number}");
            SqlCommand command = new SqlCommand(commandText1, con);
            SqlDataReader reader1 = command.ExecuteReader();
            while (reader1.Read())
            {
                System.Console.WriteLine($"ID:{reader1.GetValue(0)}, FirstName:{reader1.GetValue(1)}, LastName:{reader1.GetValue(2)}, MiddleName:{reader1.GetValue(3)},BirthDate:{reader1.GetValue(4)}");
            }
            reader1.Close();
        }

        static void Insert(string Name, string LastName, string MiddleName)
        {
            const string conString = @"Data source = AZAMOT; Initial catalog = AlifAcademy; Integrated Security=true";
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            string date = DateTime.Now.ToString("yyyy-mm-dd");
            string insertSqlCommand = string.Format($"insert into Person([FirstName],[LastName],[MiddleName],[BirthDate]) Values('{Name}', '{LastName}','{MiddleName}',{date}) ");
            SqlCommand command = new SqlCommand(insertSqlCommand, con);
            command = new SqlCommand(insertSqlCommand, con);
            var result = command.ExecuteNonQuery();
            if (result > 0)
            {
                System.Console.WriteLine("Команда завершена!!!");
            }
            con.Close();
        }

        static void Update(string Name, string LastName, string MiddleName)
        {
            const string conString = @"Data source = AZAMOT; Initial catalog = AlifAcademy; Integrated Security=true";
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            string date = DateTime.Now.ToString("yyyy-mm-dd");
            string commandText1 = ($"Update Person set FirstName='{Name}',LastName='{LastName}',MiddleName='{MiddleName}',BirthDate={date}");
            SqlCommand command = new SqlCommand(commandText1, con);
            var result = command.ExecuteNonQuery();
            if (result > 0)
            {
                System.Console.WriteLine("Обновлен!!");
            }
            con.Close();
        }

        static void Delete(int number)
        {
            const string conString = @"Data source = AZAMOT; Initial catalog = AlifAcademy; Integrated Security=true";
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            string commandText1 = ($"Delete from Person where id = {number}");
            SqlCommand command = new SqlCommand(commandText1, con);

            var result = command.ExecuteNonQuery();
            if (result > 0)
            {
                System.Console.WriteLine("Удалено!!");
            }
            con.Close();
        }



        static void Main()
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
            static void SelectById(int number)
            {
                const string conString = @"Data source = AZAMOT; Initial catalog = AlifAcademy; Integrated Security=true";
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                string commandText1 = ($"Select * from Person where id = {number}");
                SqlCommand command = new SqlCommand(commandText1, con);
                SqlDataReader reader1 = command.ExecuteReader();
                while (reader1.Read())
                {
                    System.Console.WriteLine($"ID:{reader1.GetValue(0)}, FirstName:{reader1.GetValue(1)}, LastName:{reader1.GetValue(2)}, MiddleName:{reader1.GetValue(3)},BirthDate:{reader1.GetValue(4)}");
                }
                reader1.Close();
            }

            static void Insert(string Name, string LastName, string MiddleName)
            {
                const string conString = @"Data source = AZAMOT; Initial catalog = AlifAcademy; Integrated Security=true";
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                string date = DateTime.Now.ToString("yyyy-mm-dd");
                string insertSqlCommand = string.Format($"insert into Person([FirstName],[LastName],[MiddleName],[BirthDate]) Values('{Name}', '{LastName}','{MiddleName}',{date}) ");
                SqlCommand command = new SqlCommand(insertSqlCommand, con);
                command = new SqlCommand(insertSqlCommand, con);
                var result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    System.Console.WriteLine("Команда завершена!!!");
                }
                con.Close();
            }

            static void Update(string Name, string LastName, string MiddleName)
            {
                const string conString = @"Data source = AZAMOT; Initial catalog = AlifAcademy; Integrated Security=true";
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                string date = DateTime.Now.ToString("yyyy-mm-dd");
                string commandText1 = ($"Update Person set FirstName='{Name}',LastName='{LastName}',MiddleName='{MiddleName}',BirthDate={date}");
                SqlCommand command = new SqlCommand(commandText1, con);
                var result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    System.Console.WriteLine("Обновлен!!");
                }
                con.Close();
            }

            static void Delete(int number)
            {
                const string conString = @"Data source = AZAMOT; Initial catalog = AlifAcademy; Integrated Security=true";
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                string commandText1 = ($"Delete from Person where id = {number}");
                SqlCommand command = new SqlCommand(commandText1, con);

                var result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    System.Console.WriteLine("Удалено!!");
                }
                con.Close();
            }
            Console.WriteLine("Adding : 1");
            Console.WriteLine("Select All : 2");
            Console.WriteLine("Select by Id : 3");
            Console.WriteLine("Update : 4");
            Console.WriteLine("Delete : 5");

            int choise = int.Parse(Console.ReadLine());
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
                    break;
                case 2:
                    {
                        SelectAll();
                    }
                    break;
                case 3:
                    {
                        Console.Write("Please Select Id:");
                        int number = int.Parse(Console.ReadLine());
                        SelectById(number);
                    }
                    break;
                case 4:
                    {
                        Console.Write("Enter Name:");
                        string Name = Console.ReadLine();
                        Console.Write("Enter Surname:");
                        string Surname = Console.ReadLine();
                        Console.Write("Enter MiddleName:");
                        string MiddleName = Console.ReadLine();
                        Update(Name, Surname, MiddleName);
                    }
                    break;
                case 5:
                    {
                        Console.Write("Select Id to Delete:");
                        int number = int.Parse(Console.ReadLine());
                        Delete(number);
                    }
                    break;
                default:
                    System.Console.WriteLine("Incorrect option");
                    break;
            }

        }

    }

}









