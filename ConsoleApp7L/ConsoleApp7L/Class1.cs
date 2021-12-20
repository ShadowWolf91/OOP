using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Diagnostics;

namespace ConsoleApp7L
{
        class WrongProductname : Exception 
        {
            string Value { get; set; }
            public WrongProductname(string message, string value): base(message)
            {
                Value = value; 
            }
        }

        class WrongMass : Exception
    {
            
            public WrongMass(string message) : base(message)
            {

            }
        }

        class WrongPrice : ArgumentException
    {
            int Value { get; set; }
            public WrongPrice(string message, int value) : base(message)
            {
                Value = value;
                
            }

        }

        class WrongMaterial : ArgumentOutOfRangeException
        {
            string Value { get; set; }
            public WrongMaterial(string message, string value) : base(message)
            {
                Value = value;
            }
        }

        class WrongCreator : ArgumentException
        {
            string Value { get; set; }
            public WrongCreator(string message, string value) : base(message)
            {
                Value = value;
            }
        }
    }
