﻿using Blogsstgmvc.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogsstgmvc.Entity.Entities
{
    public class Category : EntityBase
    {
        

        public string Name { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}
