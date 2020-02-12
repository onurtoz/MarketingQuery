﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLapp.Models
{
    public class Material
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Piece { get; set; }
        public Brand Brand { get; set; }
    }
}
