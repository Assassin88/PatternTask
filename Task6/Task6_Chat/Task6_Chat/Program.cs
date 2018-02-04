using System;

namespace Task6_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            var PublicGroup = new Chat();
            var ivan = new User("Ivan");
            var lena = new User("Lena");
            var jan = new User("Jan");

            ivan.AddUser(PublicGroup);
            lena.AddUser(PublicGroup);
            jan.AddUser(PublicGroup);

            ivan.Send("Hello my frieds!!!", PublicGroup);
            Console.WriteLine();

            var groupChat = ivan.LocalGroup(lena);
            ivan.Send("Hello Lena!!!", groupChat);
            lena.Send("Hello Ivan!!!", groupChat);

            Console.ReadKey();

        }
    }
}
