﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Managemnet_System.Model
{
    internal interface IPerson
    {
        int Id { get; set;}
        string Name { get; set;}
        string Phone { get; set;}

    }
}
