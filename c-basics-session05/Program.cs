using static System.Runtime.InteropServices.JavaScript.JSType;

namespace c_basics_session05
{
    internal class Program
    {
        static void Main(string[] args)
        {
# region Q1
            //Add a private string password = "secret"; field to a Book class. Try to print it from Main
            //(outside the class). What happens, and why?
            //Console.WriteLine(BookClass.password);
            //error occurs because the password field is declared as private. A private field can only be accessed within its own class,
            //so it cannot be accessed directly from the Main method outside the Book class.
#endregion
        }
    }
}
