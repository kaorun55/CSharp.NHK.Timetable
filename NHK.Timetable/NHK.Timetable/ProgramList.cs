using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NHK.Timetable
{
    public class ProgramList
    {
        public class Rootobject
        {
            public List list
            {
                get;
                set;
            }
        }

        public class List
        {
            public G1[] g1
            {
                get;
                set;
            }
        }

        public class G1
        {
            public string id
            {
                get;
                set;
            }
            public string event_id
            {
                get;
                set;
            }
            public DateTime start_time
            {
                get;
                set;
            }
            public DateTime end_time
            {
                get;
                set;
            }
            public Area area
            {
                get;
                set;
            }
            public Service service
            {
                get;
                set;
            }
            public string title
            {
                get;
                set;
            }
            public string subtitle
            {
                get;
                set;
            }
            public string[] genres
            {
                get;
                set;
            }
        }

        public class Area
        {
            public string id
            {
                get;
                set;
            }
            public string name
            {
                get;
                set;
            }
        }

        public class Service
        {
            public string id
            {
                get;
                set;
            }
            public string name
            {
                get;
                set;
            }
            public Logo_S logo_s
            {
                get;
                set;
            }
            public Logo_M logo_m
            {
                get;
                set;
            }
            public Logo_L logo_l
            {
                get;
                set;
            }
        }

        public class Logo_S
        {
            public string url
            {
                get;
                set;
            }
            public string width
            {
                get;
                set;
            }
            public string height
            {
                get;
                set;
            }
        }

        public class Logo_M
        {
            public string url
            {
                get;
                set;
            }
            public string width
            {
                get;
                set;
            }
            public string height
            {
                get;
                set;
            }
        }

        public class Logo_L
        {
            public string url
            {
                get;
                set;
            }
            public string width
            {
                get;
                set;
            }
            public string height
            {
                get;
                set;
            }
        }

    }
}
