﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Siringa.Engine.Interfaces
{
    public interface IIPObtainerStrategy : IWebOperation
    {

        string GetIp();
    }
}