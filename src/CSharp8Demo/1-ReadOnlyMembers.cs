using System;
using System.Text;
using System.Collections.Generic;

// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/readonly

namespace CSharp8Demo
{
    public struct Rectangle
    {
        public double Length { get; set; }

        // in this type of property, 'get' is readonly because you cann't change anything while doing the 'get'
        //public double Height { get; set; }

        private double _height;
        public double Height
        {
            readonly get
            {
                // this is not a readonly 'get', we can write our code to make the changes in the '_height'
                // for example, _height += 1;
                return _height;
            }
            set { _height = value; }
        }

        // when creating an instance of the struct 'Rectangle' and calling the method 'Area()'
        // the system processing it will create a deffensive copy of it because this method may change someting in it.
        // that diffensive copy will take a little bit of extra memory.
        // So what we can do is make a read only method.
        public readonly double Area()
        {
            // Height += 1; // now Height in Area method is 'readonly'.
            return Length * Height;
        }

        // 'readonly' keyword says that we cann't make any change in the method
        //  now the compiler will not make a diffensive copy of the method, so save some memory.
        //  So, essensially, its a performance optimization.
    }
}
