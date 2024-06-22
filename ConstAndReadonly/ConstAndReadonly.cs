using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Xsl;


namespace ConstAndReadonly
{
    public class ConstAndReadonly
    {

        //constant 

        public const int constVariable = 1;

        private readonly string str;

        public ConstAndReadonly(string a)
        {
            str = a;          
        }

    }
}
