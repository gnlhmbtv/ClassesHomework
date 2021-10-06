using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesHomework
{
    class Laptop:Devices
    {
        
        string processor;
        string memorytype;
        public Laptop( string brend, string name, string colour,string processor, string memorytype,int memorysize,int ram)
        {
            this.brend = brend;
            this.name = name;
            this.colour = colour;
            this.processor = processor;
            this.memorytype = memorytype;
            this.memorysize = memorysize;
            this.ram = ram;
        }
        
    }
}
