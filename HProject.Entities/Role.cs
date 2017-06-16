﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HProject.Entities
{
    /// <summary>
    /// Project Role
    /// </summary>
    public class Role : IEntityBase
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
