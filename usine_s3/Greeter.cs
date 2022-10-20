using System;
using System.Collections.Generic;
using System.Text;

namespace usine_s3
{
    public class Greeter
    {
        public string Greet(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            return $"Hi, {name}";
        }
    }
}
