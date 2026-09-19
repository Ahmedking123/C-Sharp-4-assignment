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
        }
    }
}
