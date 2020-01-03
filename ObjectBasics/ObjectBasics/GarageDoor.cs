using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectBasics
{
    public class GarageDoor
    {
        string _doorId = "";
        public bool Open = false;

        public GarageDoor(string doorId)
        {
            _doorId = doorId;
        }

        public void ChangeDoor()
        {
            // Send a signal to the door
            // ...
            SendToggleSignal();

            // Update the door open status
            Open = CheckIfDoorOpen();
        }

        void SendToggleSignal()
        {
            // Send signal to the garage door system to change the door state
            // ...
        }

        bool CheckIfDoorOpen()
        {
            bool doorOpen = false;
            // check the status of the door
            // ...

            // Simulate the door being in a different state than current
            if (Open == true)
            {
                doorOpen = false;
            }
            else
            {
                doorOpen = true;
            }

            return doorOpen;
        }
    }
}
