using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TString_Editor
{
    class Structure
    {
        public Int16 ID;
        public String String;

        public Structure(Int16 ID = 0, String String = "New string")
        {
            this.ID = ID;
            this.String = String;
        }
    }
}
