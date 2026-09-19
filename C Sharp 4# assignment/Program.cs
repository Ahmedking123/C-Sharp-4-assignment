using System.Runtime.InteropServices;

namespace C_Sharp_4__assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region First question

            Book book = new Book();
            Console.WriteLine(book.password);
            //can't access it due to its protection level being private

            #endregion
            #region Second question

            Console.WriteLine(book.copiesInStock);
            // can access it since its protection level is internal and the Program class is in the same project

            #endregion
            #region Third question

            Console.WriteLine(book.title);

            #endregion
            #region Fourth question

            book.genre = Genre.Science;
            Console.WriteLine(book.genre);

            #endregion
            #region Fifth question

            Console.WriteLine($"{(int)Genre.Fiction} { (int)Genre.NonFiction} { (int)Genre.Science}");

            #endregion
            #region Sixth question

            int genreNumber = 1;
            Console.WriteLine((Genre)genreNumber);

            #endregion
            #region Seventh question

            Genre genre = Genre.Fiction;
            Console.WriteLine(genre.ToString());

            #endregion
            #region Eighth question

            string genreText = "Science";
            genre = (Genre)Enum.Parse(typeof(Genre), genreText,true);
            Console.WriteLine(genre);

            #endregion
            #region Ninth question

            genreText = "Mystery";
            if (Enum.TryParse(genreText, true, out genre))
            {
                Console.WriteLine(genre);
            }
            else
            {
                Console.WriteLine("Unknown genre");
            }

            #endregion
        }
    }
}
