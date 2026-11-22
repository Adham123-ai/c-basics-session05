using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace c_basics_session05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Add a private string password = "secret"; field to a Book class. Try to print it from Main
            //(outside the class). What happens, and why?
            ///BookClass b = new BookClass();
            ///Console.WriteLine(b.password);
            //error occurs because the password field is declared as private. A private field can only be accessed within its own class,
            //so it cannot be accessed directly from the Main method outside the Book class.
            #endregion
            #region Q2
            //Add an internal int copiesInStock = 5; field to Book. Print it from Main. Does it compile?
            //Why ?
            ///BookClass c = new BookClass();
            ///Console.WriteLine(c.copiesInStock);
            //Yes, it compiles successfully because internal members can be accessed from anywhere within the same assembly
            #endregion
            #region Q3
            // Add a public string Title; field to Book.Set it and print it from Main.
            ///BookClass d = new BookClass();
            ///d.Title = "C#";
            ///Console.WriteLine(d.Title);


            #endregion
            #region Q4
            //Declare an enum Genre { Fiction, NonFiction, Science }. Add a Genre property to Book,
            //assign it Genre.Science, and print it.
            ///BookClass b = new BookClass();
            /// b.Genre = enum_Genre.Science;
            ///Console.WriteLine(b.Genre);
            #endregion
            #region Q5
            //Using the Genre enum above, print the underlying int value of
            //Genre.Fiction, Genre.NonFiction, and Genre.Science by casting each to int.
            BookClass b = new BookClass();
            b.Gerne = enum_Genre.Fiction;
            Console.WriteLine((int)b.Genre);
            b.Genre = enum_Genre.NonFiction;
            Console.WriteLine((int)b.Genre);

            #endregion
        }
    }
}
