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
            //BookClass b = new BookClass();
            //Console.WriteLine(b.password);
            //error occurs because the password field is declared as private. A private field can only be accessed within its own class,
            //so it cannot be accessed directly from the Main method outside the Book class.
            #endregion
            #region Q2
            //Add an internal int copiesInStock = 5; field to Book. Print it from Main. Does it compile?
            //Why ?
            BookClass c = new BookClass();
            Console.WriteLine(c.copiesInStock);
            //Yes, it compiles successfully because internal members can be accessed from anywhere within the same assembly.
            




            #endregion
        }
    }
}
