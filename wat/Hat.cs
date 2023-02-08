using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    internal class Hat
    {
        public enum College {Gryffendor=1,Hufflepuff,Ravenclaw,Slytherin};//enum full of colleges

        public College Sort()//Easy method to choose which college
        {
            Random rnd = new Random();
            return (College)rnd.Next(1, 5);//returns random college for the user.
        }
    }
}
