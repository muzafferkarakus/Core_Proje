﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Skill
    {
        [Key]
        public int SkillId { get; set; }
        public string Title { get; set; }
        public string Values { get; set; }
    }
}
