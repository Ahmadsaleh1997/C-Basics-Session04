namespace C__Basics_Session04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            // Create a one-dimensional array double[] prices with the values 25.5, 40.0, 33.75. Print the second price (index 1).

            double[] prices = { 25.5, 40.0, 33.75 };
            Console.WriteLine(prices[1]);
            #endregion

            #region Q2
            // Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and shelf 1 has 1, 4 copies. Print the number of copies on shelf 1, slot 0. 

            int[,] shelfCopies = { { 3, 5 }, 
                                   { 1, 4 } };
            Console.WriteLine(shelfCopies[1, 0]);
            #endregion

            #region Q3

            // Write a method called PrintWelcomeMessage that takes no parameters and prints "Welcome to the Library!". Call it from Main. 

            static void PrintWelcomeMessage()
            {
                Console.WriteLine("Welcome to the Library!");
            }

            PrintWelcomeMessage();

            #endregion

            #region Q4
            // Write a method PrintBookTitle(string title) that prints "Book title: " + title. Call it with "Clean Code". 
            static void PrintBookTitle(string title)
            {
                Console.WriteLine($"Book Title: {title}");
            }

            PrintBookTitle("Clean Code");

            #endregion

            #region Q5
            // Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable int pages = 400; and print pages afterward. What do you expect to see, and why?
            static int AddBounusPages(int pages)
            {
                pages += 50;
                return pages;
            }

            int pages = 400;
            int  Add = AddBounusPages(pages);
            Console.WriteLine($"Pages before bonus: {pages}");
            Console.WriteLine($"Pages After bonus: {Add}");
            // the original variable pages will remain unchanged because the method AddBonusPages takes a copy of the value of pages, modifies that copy, and returns it. The original variable pages in Main remains 400.
            #endregion

            #region Q6

            // Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0]. Call it with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward. What do you expect to see, and why?

            static void ApplyDiscount( ref double[] price)
            {
                price[0] -= 5.0;
            }

            double[] price = { 25.5, 40.0};
            ApplyDiscount(ref price);
            Console.WriteLine($"Price after discount: {price[0]}");
            // The original array will be modified because arrays are passed by reference in C#.
            #endregion

            #region Q7
            // Rewrite the method from question 5 as AddBonusPagesByRef(ref int pages) using ref. Call it and print pages afterward. How is the result different from question 5? 
            static int AddBonusPagesByRef (ref int pages)
            {
                pages += 50;
                return pages;
            }
            
            int pagesRef = 400;
            Console.WriteLine($"Pages before bonus (by ref): {pagesRef}");
            AddBonusPagesByRef(ref pagesRef);
            Console.WriteLine($"Pages after bonus (by ref): {pagesRef}");
            // The original variable pagesRef will be modified because it is passed by reference to the method AddBonusPagesByRef.
            #endregion

            #region Q8
            // Write a method ReplaceArray(ref double[] prices) that replaces prices entirely with a new array { 10.0, 12.5, 15.0 }. Call it with your prices array and print prices.Length afterward. 

            static void ReplaceArray(ref double[] prices)
            {
                prices = new double[] { 10.0, 12.5, 15.0 };
            }
            double[] OLDprices = { 1.0, 2.0, 3.0, 4.0, 5.0 };
            Console.WriteLine($"length {OLDprices.Length}");

            ReplaceArray(ref OLDprices);

            Console.WriteLine($"Length of prices after replacement: {OLDprices.Length}");


            #endregion

            #region Q9
            // Write a method bool TryGetPrice(string title, out double price) that returns true and sets price to 25.5 if title is "Clean Code", otherwise returns false and sets price to 0. Call it 1 and print the price if found  


            static bool TryGetPrice(string title, out double price)
                {
                    if (title == "Clean Code")
                    {
                        price = 25.5;
                        return true;
                    }
                    else
                    {
                        price = 0;
                        return false;
                    }
                }
            bool result = TryGetPrice("Clean Co", out double p);
            if (result==true)
            {
                Console.WriteLine($"Price for 'Clean Code': {p}");
            }
            else
            {
                Console.WriteLine("price is Zero");
            }
            #endregion

            #region Q10
            // Write a method PrintBookInfo(string title, int pages = 300) where pages is optional. Call it once with only a title, and once passing both a title and pages. 

            static void PrintBookInfo(string title,int pages =300)
            {
                Console.WriteLine($"Book Title: {title}, Pages: {pages}");
            }
            PrintBookInfo("the animal farm");
            PrintBookInfo("the animal farm",350);

            #endregion

            #region Q11

            // Using the PrintBookInfo method from the question above, call it by naming the parameters, passing pages before title.
            PrintBookInfo(pages: 464, title: "Code Complete");
            #endregion

            #region 12
            // Write a method PrintAllTitles(params string[] titles) that prints each title on its own line. Call it with three book titles. 

            static void PrintAllTitles(params string[] titles)
            {
                foreach (var title in titles)
                {
                    Console.WriteLine(title);
                }
            }

            PrintAllTitles("Animal farm", "1984", "Code Complete");

            #endregion
        }
    }
}
