
namespace GradeBook
{
    class Program
    {
        static void Main(string[] args) // Method named "Main"
        {
            var book = new Book("Datwon's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.1);
            book.AddGrade(77.5);
            book.ShowStats();
        }
    }
}
