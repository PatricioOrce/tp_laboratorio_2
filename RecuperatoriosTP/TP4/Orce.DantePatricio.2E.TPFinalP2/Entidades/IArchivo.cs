﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IArchivo<T>
    {

        T Leer(string path);

        void Escribir(T dato, string path);
    }
}