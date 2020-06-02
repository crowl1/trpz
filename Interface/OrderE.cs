﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class OrderE
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string NameCustomer { get; set; }
        [Required]
        public long TimeLeft { get; set; }

        [Required]
        public int Manager { get; set; }
        [Required]
        public int Good { get; set; }
        [ForeignKey(nameof(Manager))]

        public StorageE StorageID { get; set; }
        [ForeignKey(nameof(Good))]
        public GoodE GoodID { get; set; }
    }
}
