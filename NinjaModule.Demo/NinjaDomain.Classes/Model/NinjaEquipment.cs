﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjaDomain.Classes.Model
{
    public class NinjaEquipment
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public EquipmentType Type { get; set; }

        public Ninja Ninja { get; set; }
    }
}
