﻿using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.D_2015
{
    public abstract class Entity : IEntity
    {
        public int Id { get; set; }
    }
}
