namespace OperationStateProject
{
    class Matrix
    {
        int[,] matrix = new int[3, 4] { { 1, 2, 3, 4}, { 5, 6, 7, 8}, { 9, 10, 11, 12} };

        public int this[int i, int j]
        {
            set { matrix[i,j] = value; }
            get { return matrix[i, j]; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Money money = new(5, 0);

            ////Console.WriteLine(money % 10);

            //money += 200;
            //Console.WriteLine(money);
            //money = 123.789;
            //Console.WriteLine(money);

            //int n = (int)money;

            Company company = new(new[]
            {
                new User("Bob"),
                new User("Joe"),
                new User("Tim")
            });

            User user = company[1];
            Console.WriteLine(user.Name);

            company[2] = new User("Sam");
            Console.WriteLine(company[2].Name);

            company["title"] = "Yandex";
            company["phone"] = "+7 945 123-45-67";
            company["email"] = "yandex@yandex.ru";

            Console.WriteLine($"{company["title"]} {company["phone"]} {company["email"]}");

            Matrix matrix = new();
            for(int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                    Console.Write($"{matrix[i, j]}\t");
                Console.WriteLine();
            }
        }
    }
}