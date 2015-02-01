using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walk_in_Library
{
    public partial class Book
    {
        public override string ToString()
        {
            // Initialize a new StringBuilder object to collect output
            StringBuilder output = new StringBuilder();

            // Append each property to output
            output.AppendFormat("Id == %1; ", Id.ToString());

            // Return the output
            return output.ToString();
        }
    }
}
