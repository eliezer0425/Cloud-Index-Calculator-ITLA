﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloud_Index_Calculator_ITLA.Model
{
    class Career
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ShortName { get; set; }

        public ICollection<Subject> Subjets { get; set; }
    }
}
