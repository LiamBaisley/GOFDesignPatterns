﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioural.Observer
{
    internal interface IObserver
    {
        void MessageSent(string message);
    }
}
