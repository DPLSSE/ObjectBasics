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
            if (!Open)
            {
                // open the door and wait until it is open
                // ...
                SendToggleSignal();

                // Set the door open status
                Open = CheckIfDoorOpen();
            }
        }

        void SendToggleSignal()
        {
            // send signal to the garage door system to change the door status
            // ...
        }

        bool CheckIfDoorOpen()
        {
            bool doorOpen = false;
            // send signal to the garage door system to determine if door is open
            // ...
            return doorOpen;
        }
    }
}
