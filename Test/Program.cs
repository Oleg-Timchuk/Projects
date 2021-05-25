using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.Globalization;
using System.IO;

namespace Test
{
    class Program
    {

        public static void AddElFirst(ref int[] mas, int a)
        {
            var massiv = new int[mas.Length + 1];
            massiv[0] = a;
            for (int i = 1; i < massiv.Length; i++)
            {
                massiv[i] = mas[i - 1];
            }
            mas = massiv;
        }

        public static void AddElLast(ref int[] mas, int a)
        {
            var massiv = new int[mas.Length + 1];
            massiv[mas.Length] = a;
            for (int i = 0; i < massiv.Length - 1; i++)
            {
                massiv[i] = mas[i];
            }
            mas = massiv;
        }

        public static void AddElIndex(ref int[] mas, int indx, int a)
        {
            var massiv = new int[mas.Length + 1];
            massiv[indx] = a;
            for (int i = 0; i < massiv.Length - 1; i++)
            {
                if (massiv[i] == 0)
                {
                    massiv[i] = mas[i];
                }
                else
                {
                    massiv[i + 1] = mas[i];
                }
            }
            mas = massiv;
        }

        public static void Resize(ref int[] mas, int a)
        {
            var massiv = new int[a];
            for (int i = 0; i < mas.Length && i < massiv.Length; i++)
            {
                massiv[i] = mas[i];
            }
            mas = massiv;
        }

        public static void DelElLast(ref int[] mas)
        {
            var massiv = new int[mas.Length - 1];
            for (int i = 0; i < massiv.Length; i++)
            {
                massiv[i] = mas[i];
            }
            mas = massiv;
        }

        public static void DelElFirst(ref int[] mas)
        {
            var massiv = new int[mas.Length - 1];
            for (int i = 0; i < massiv.Length; i++)
            {
                massiv[i] = mas[i + 1];
            }
            mas = massiv;
        }

        public static int CountChar(string mas)
        {
            var counter = 0;
            for (int i = 0; i < mas.Length - 1; i++)
            {
                char temp = mas[i];
                var b = mas.Count(t => (temp == mas[i + 1]));
                if (b > 0)
                {
                    counter++;
                }

            }
            return counter;
        }

        static void Main(string[] args)
        {
            string SqlConnection = "server=localhost;user=root;database=people;password=1234";

            var Connection = new MySqlConnection(SqlConnection);

            Connection.Open();

            string sql = "SELECT id, name FROM men WHERE age = 22";

            var Command = new MySqlCommand(sql, Connection);

            MySqlDataReader reader = Command.ExecuteReader();

            Command.ExecuteScalar().ToString();

            while (reader.Read())
            {
                Console.WriteLine(reader[0].ToString());
                Console.WriteLine(reader[1].ToString());
            }

            reader.Close();

            Connection.Close();
        }
    }
}
