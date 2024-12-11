using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeKoelkast.Api
{
    public class Question
    {
        public string id { get; set; }
        public string type { get; set; }
        public string rating { get; set; }
        public string question { get; set; }
        public Translations translations { get; set; }
    }
}