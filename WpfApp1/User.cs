﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class User
    {
        [Key] public int ID { get; set; }

        public string RegNo { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

    }



}
