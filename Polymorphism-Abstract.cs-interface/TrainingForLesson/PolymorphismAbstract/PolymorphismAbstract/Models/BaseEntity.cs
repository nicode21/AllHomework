﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismAbstract.Models
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
