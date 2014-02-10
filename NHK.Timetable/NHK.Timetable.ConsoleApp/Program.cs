using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHK.Timetable.ConsoleApp
{
    class Program
    {
        static void Main( string[] args )
        {
            try {
                var timetable = new NhkTimetable( ConfigurationManager.AppSettings["Token"] );
                var nowonair = timetable.GetNowOnAir().Result;
                Console.WriteLine( nowonair.nowonair_list.g1.present.title );
                Console.WriteLine( nowonair.nowonair_list.g1.present.start_time.ToString() );
                Console.WriteLine( nowonair.nowonair_list.g1.present.end_time.ToString() );
                Console.WriteLine( nowonair.nowonair_list.g1.present.area.name );
            }
            catch ( Exception ex ) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
