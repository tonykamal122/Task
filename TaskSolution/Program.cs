using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskSolution.Models;
using TaskSolution.DataBaseDbContext;
namespace TaskSolution
{
    class Storage<T>
    {
        private T A;

        public void SetValue(T B)
        {
            A = B;
        }

        public T GetValue()
        {
            return A;
        }
    }
    class Calculator<T>
    {
        public T Add(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            return (T)x + y;
        }

        public T Subtract(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            return (T)x - y;
        }

        public T Multiply(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            return (T)x * y;
        }

        public T Divide(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            return (T)x / y;
        }
    }
    class DataHolder<T> where T : struct
    {
        private T A;
        public DataHolder(T B)
        {
            A = B;
        }
        public void Display()
        {
            Console.WriteLine(A);
        }
    }
    struct Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Area()
        {
            return Width * Height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            /* Q1 - Explain how ef core determine default table and column names when no configuration is specified
             how can you override these defaults ? when we make a class with properties the default name will be the same names of this properties
            and we can override the name with 2 ways using fluent apis and using [Table("")] annotation
             */

            // Q2 - What is theeffect of calling ASNoTracking() in Linq query?
            // and provide a Secnario where this option is useful?
            // when  we retrive data only and we won't change it on the database at all or we want to use the data in out program
            // */

            using MusiciansDbContext dbContext = new MusiciansDbContext();
            var Musician = new Musician
            {
                FirstName = "Tony",
                LastName = "Kamal",
                PhoneNumber = "01122334455",
                Email = "tonykamal123@gmail.com",
                Password = "Tony@12345",
                City = "Cairo",
                County = "Egypt"
            };
            dbContext.Musicians.Add(Musician);
            dbContext.SaveChanges();
            Console.WriteLine("Record Created");


            var Musician02 = dbContext.Musicians.FirstOrDefault(m => m.MusId == 10);
            Console.WriteLine($"{Musician02.MusId} {Musician02.FirstName} {Musician02.LastName}");


            Musician02.City = "Giza";
            Musician02.PhoneNumber = "0111111111";
            dbContext.SaveChanges();
            Console.WriteLine("Record Updated");


            dbContext.Musicians.Remove(Musician02);
            dbContext.SaveChanges();
            Console.WriteLine("Record Removed");


        }
    }

}