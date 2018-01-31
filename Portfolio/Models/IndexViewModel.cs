using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfolio.Models
{
    public class IndexViewModel
    {
        public string Introduction { get; set; }
        public List<KeyValuePair<string, int>> SkillSet{get;set;}
    }
}