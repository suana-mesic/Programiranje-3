﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IB230022
{
    [Table("SemestriIB230022")]
    public class SemestriIB230022
    {
        public int Id { get; set; }
        public string Naziv { get; set; }

    }
}
