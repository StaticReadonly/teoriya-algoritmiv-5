using Classes;

namespace Lab5
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            FileReader reader = new FileReader();

            var result = await reader.ReadFile("D:\\KPI Labs\\Теорія алгоритмів\\lab5\\Lab5\\Files\\test1.cpp");

            foreach(var r in result.TreeTraversal())
            {
                Console.WriteLine(r.Item1 + " " + r.Item2);
            }
        }
    }
}
