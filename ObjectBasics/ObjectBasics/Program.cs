using System;

namespace ObjectBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** OBJECT BASICS ***");

            #region Other Details
            //CreatingObjects();
            CopyingTypes();
            #endregion

            #region Passing Parameters

            //Console.WriteLine("*** Passing Parameters to Methods ***");

            //int localCounter = 7;
            //GarageDoor localDoor = new GarageDoor("ABC123");
            //// print out the local variable
            //Console.WriteLine("localCounter = " + localCounter);
            //Console.WriteLine("localDoor Open = " + localDoor.Open);
            //Console.WriteLine();

            //// Pass the local variables to a method
            //PassingParameters(localCounter, localDoor);

            //// print out the local variable again
            //Console.WriteLine("localCounter = " + localCounter);
            //Console.WriteLine("localDoor Open = " + localDoor.Open);
            //Console.WriteLine();

            #endregion

            Console.ReadLine();
        }

        static void CreatingObjects()
        {
            GarageDoor door1 = new GarageDoor("ABC123");

            GarageDoor door2 = new GarageDoor("DEF456");

            // print out the current door states
            Console.WriteLine("Door 1 open = " + door1.Open); // False
            Console.WriteLine("Door 2 open = " + door2.Open); // False
            Console.WriteLine();

            // send a signal to open door 1
            door1.ChangeDoor();

            // print out the new door states
            Console.WriteLine("Door 1 open = " + door1.Open); // True
            Console.WriteLine("Door 2 open = " + door2.Open); // False
        }

        static void CopyingTypes()
        {
            int counter = 7;
            GarageDoor door = new GarageDoor("ABC123");

            // Copy the variables
            int counter2 = counter;
            GarageDoor door2 = door;

            // Print out the original values
            Console.WriteLine("*** Original Values ***");
            Console.WriteLine("counter = " + counter); // 7
            Console.WriteLine("counter2 = " + counter2); // 7
            Console.WriteLine("door Open = " + door.Open); // False
            Console.WriteLine("door2 Open = " + door2.Open); // False
            Console.WriteLine();

            // modify the value/state of the original variables
            counter += 1; // Adds 1 to counter
            door.ChangeDoor(); // Toggles the status of the Open property
            Console.WriteLine("*** Modified counter and door variables ****");
            Console.WriteLine("counter = " + counter); // 8
            Console.WriteLine("counter2 = " + counter2); // 7
            Console.WriteLine("door Open = " + door.Open); // True
            Console.WriteLine("door2 Open = " + door2.Open); // True
        }

        static void PassingParameters(int methodCounter, GarageDoor methodDoor)
        {
            // modify the passed parameters
            methodCounter = 8;
            methodDoor.ChangeDoor();

            // print out the local variable
            Console.WriteLine("methodCounter = " + methodCounter);
            Console.WriteLine("methodDoor Open = " + methodDoor.Open);
            Console.WriteLine();
        }
    }
}
