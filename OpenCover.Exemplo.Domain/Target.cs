﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCover.Exemplo.Domain
{
    public class Target
    {
        public static void DoSomething()
        {
            try
            {
                Console.WriteLine("I ran!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
