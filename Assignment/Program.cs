using System;

namespace Assignements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assignment 1: Create a 1-dimensional array named groceries that contains things you've had for breakfast Monday through Friday (5 values).
            string[] groceries = { "Okpa", "Bread", "Rice", "Eggs", "Cereal" };

            // Assignment 2: Create a 1-dimensional array (int) that corresponds to how much the food you had satisfied you (1 to 5).
            int[] ratings = { 5, 2, 4, 3, 1 };

            // Assignment 3: Using "Console.WriteLine()" print out a sentence using elements from the above arrays.
            // Example: The food I had on Monday was ______ and it was ____ stars.
            Console.WriteLine($"The food I had on Monday was {groceries[0]} and it was {ratings[0]} stars.");

            // Assignment 4: Create a 2-dimensional string array. It will have 3 rows and 4 columns and call it library.
            // Each row represents a book and the columns are: title, author, publishing date, genre.
            string[,] library =
            {
                { "Math Book", "Mr. Smith", "2010", "Education" },
                { "Space Ship", "Jane Doe", "2015", "Sci-Fi" },
                { "Cat Story", "Tom Cat", "2020", "Comedy" }
            };

            // Print out the genre of the second book.
            Console.WriteLine($"The genre of the second book is {library[1, 3]}");

            // And the publishing date of the 3rd book.
            Console.WriteLine($"The publishing date of the third book is {library[2, 2]}");
        }
    }
}