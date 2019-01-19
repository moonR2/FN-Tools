using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FNFNTOOLS
{
    class status
    {

        public class Rootobject
        {
            public string status { get; set; }
            public string message { get; set; }
            public string version { get; set; }
            public Time time { get; set; }
        }

        public class Time
        {
            public Since since { get; set; }
            public Duration duration { get; set; }
        }

        public class Since
        {
            public string seconds { get; set; }
        }

        public class Duration
        {
            public int seconds { get; set; }
            public string formated { get; set; }
        }

    }
}
