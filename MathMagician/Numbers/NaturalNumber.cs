﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class NaturalNumber : Integer
    {
        
        private int First { get; set; }
        
        public NaturalNumber()
        {
            First = 1;
            // this.First = 1;
        }

        public int GetFirst()
        {
            return First;
        }

        public int GetNext(int current)
        {
            throw new NotImplementedException();
        }

        public int[] GetSequence(int howMany)
        {
            throw new NotImplementedException();
        }

        public string PrintNumbers(int[] howMany)
        {
            throw new NotImplementedException();
        }
    }
}