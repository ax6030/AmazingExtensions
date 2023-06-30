using AmazingExtensions;          //以類別方式引用擴充功能
namespace AmazingExtensions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "Evil clones are wreaking havoc. Help!";
            if(message.IsDistressCall())
                Console.WriteLine(message);
        }
    }
}