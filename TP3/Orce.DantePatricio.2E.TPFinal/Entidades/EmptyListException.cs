﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EmptyListException : Exception
    {
        public EmptyListException(string message) : base(message)
        {
        }
    }
}
