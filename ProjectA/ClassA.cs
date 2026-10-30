using System;

namespace ProjectA
{
    class ClassA
    {
        private string privateVar = "Private : only Accessable within the class";

        void DisplayClassMembers()
        {
            Console.WriteLine(privateVar);
            Console.ReadLine();
        }

        static void Main()
        {
            ClassA a = new ClassA();
            a.DisplayClassMembers();
        }
    }

}
