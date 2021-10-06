using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesHomework
{
    class Devices
    {
        public string brend;
        public string name;
        public string colour;
        public int memorysize;
        public int ram;
        public string Pc()
        {
            return $"{brend} {name} {colour} {memorysize} {ram}";
        }

        public string Mobile()
        {
            return $"{brend} {name} {colour} {memorysize} {ram}";
        }
    }
}
