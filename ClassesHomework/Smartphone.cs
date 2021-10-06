using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesHomework
{
    class Smartphone:Devices
    {
        

        public Smartphone(string b, string n,string c, int m,int r)
        {
            brend = b;
            name = n;
            colour = c;
            memorysize = m;
            ram = r;
        }
        public string Mobile()
        {
            return $"{brend} {name} {colour} {memorysize} {ram}";
        }

       
    }
}
