using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Brello.Models
{
    public class Color : IComparable
    {
        public int ColorId { get; }
        public string Name { get; set; }
        public string Value { get; set; }

        public int CompareTo(object obj)
        {
            Color other_color = obj as Color;
            // Other way to cast
            // Color other_color = (Color)obj;
            return this.Name.CompareTo(other_color.Name);
            /*if (this.Name == other_color.Name)
            {
                return 0;
            }
            //throw new NotImplementedException();
            else if (this.Name < other_color.Name)
            {
                return -1;
            }*/
        }
        //public static int operator<=>(object obj)
        //{
        //    return 0;
        //}

        //public static int operator <=(object obj)
        //{
        //    return 0;
        //}

        //public static int operator >=(object obj)
        //{
        //    return 0;
        //}
    }
}