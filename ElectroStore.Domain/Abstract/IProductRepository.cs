﻿using ElectroStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectroStore.Domain.Abstract
{
   public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
    }
}
