using System;

namespace singly_linked_list
{
    //each node list of the information part and link to the next mode
    class node
    {
        public int rollNumber;
        public string name;
        public node next;
    }

    class list
    {
        node START;

        public list()
        {
            START = null;
        }

        public void addNote()
        {
            int rollNo;
            string nm;
            Console.WriteLine("\nEnter the roll number of the student: ");
            rollNo = Convert.ToInt32(Console.ReadLine());
            nm = Console.ReadLine();
        }

    }

    class program
    {
        static void main(string
    }
}