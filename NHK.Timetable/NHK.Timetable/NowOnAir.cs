using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHK.Timetable
{
    public class NowOnAir
    {
        public class Rootobject
        {
            public Nowonair_List nowonair_list
            {
                get;
                set;
            }
        }

        public class Nowonair_List
        {
            public G1 g1
            {
                get;
                set;
            }
        }

        public class G1
        {
            public Previous previous
            {
                get;
                set;
            }
            public Present present
            {
                get;
                set;
            }
            public Following following
            {
                get;
                set;
            }
        }

        public class Previous
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

        public class Present
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
            public Area1 area
            {
                get;
                set;
            }
            public Service1 service
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

        public class Area1
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

        public class Service1
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
            public Logo_S1 logo_s
            {
                get;
                set;
            }
            public Logo_M1 logo_m
            {
                get;
                set;
            }
            public Logo_L1 logo_l
            {
                get;
                set;
            }
        }

        public class Logo_S1
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

        public class Logo_M1
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

        public class Logo_L1
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

        public class Following
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
            public Area2 area
            {
                get;
                set;
            }
            public Service2 service
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

        public class Area2
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

        public class Service2
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
            public Logo_S2 logo_s
            {
                get;
                set;
            }
            public Logo_M2 logo_m
            {
                get;
                set;
            }
            public Logo_L2 logo_l
            {
                get;
                set;
            }
        }

        public class Logo_S2
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

        public class Logo_M2
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

        public class Logo_L2
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
