﻿using System;

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
            node newnode = new node();
            newnode.rollNumber = rollNo;
            newnode.name = nm;
            //if trhe node to be interested is the first node
            if((START != null) || (rollNo == START.rollNumber))
                {
                if ((START != null) && (rollNo == START.rollNumber))
                {
                    Console.WriteLine();
                    return;
                }
                newnode.next = START;
                START = newnode;
                return;

            }
            node previous, current;
            previous = START;
            current = START;
            while ((current != null) && (rollNo >= current.rollNumber))
            {
                if(rollNo == current.rollNumber)
                {
                    Console.WriteLine();
                    return;

                }
                previous.next = current;
                previous.next = newnode;


            }
            newnode.next = current;
            previous.next = newnode;

        }
        

    }

    class program
    {
        
    }
}