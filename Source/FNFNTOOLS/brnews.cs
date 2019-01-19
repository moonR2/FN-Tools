using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FNFNTOOLS
{
    class brnews
    {

        public class newsRoot
        {
            public string type { get; set; }
            public string typesm { get; set; }
            public Entry[] entries { get; set; }
        }

        public class Entry
        {
            public string title { get; set; }
            public string body { get; set; }
            public string image { get; set; }
            public string time { get; set; }
        }

    }
}
