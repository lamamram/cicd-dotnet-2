using System;
using System.Collections.Generic;
using System.Text;

namespace usine_s3
{
    public class Greeter
    {
        public string Greet(string name, string mode=null)
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            if (mode == "upper")
            {
                name = name.ToUpper();
            }
            return $"Hi, {name}";
        }
    }
}
