﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2.Data
{
    public interface IData
    {
        IList<User> Users { get; }
    }
}
