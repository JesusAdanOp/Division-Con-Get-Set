using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division_Con_Get_Set
{
    internal class cldivision
    {
        double v1, v2;

        public double V1
        {
            get { return v1; }
            set { v1 = value; }
        }

        public double V2
        {
            get { return v2; }
            set { v2 = value; }
        }

        public double dividir()
        {
            return v1 / v2;
        }
    }
}
