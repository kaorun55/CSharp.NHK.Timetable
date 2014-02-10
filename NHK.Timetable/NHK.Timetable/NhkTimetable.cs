using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NHK.Timetable
{
    public class NhkTimetable
    {
        string apiKey = string.Empty;

        public NhkTimetable( string apiKey )
        {
            this.apiKey = apiKey;
        }

        public async Task<ProgramList.Rootobject> GetProgramList()
        {
            var request = string.Format( @"http://api.nhk.or.jp/v1/pg/list/130/g1/2014-02-10.json?key={0}", apiKey );
            var responce = await GetResponse( request );

            return JsonConvert.DeserializeObject<ProgramList.Rootobject>( responce );
        }

        public async Task<ProgramGenre.Rootobject> GetProgramGenre()
        {
            var request = string.Format( @"http://api.nhk.or.jp/v1/pg/genre/130/g1/0000/2014-02-10.json?key={0}", apiKey );
            var responce = await GetResponse( request );

            return JsonConvert.DeserializeObject<ProgramGenre.Rootobject>( responce );
        }

        public async Task<ProgramInfo.Rootobject> GetProgramInfo()
        {
            var request = string.Format( @"http://api.nhk.or.jp/v1/pg/info/130/g1/2014021003527.json?key={0}", apiKey );
            var responce = await GetResponse( request );

            return JsonConvert.DeserializeObject<ProgramInfo.Rootobject>( responce );
        }

        public async Task<NowOnAir.Rootobject> GetNowOnAir()
        {
            var request = string.Format( @"http://api.nhk.or.jp/v1/pg/now/130/g1.json?key={0}", apiKey );
            var responce = await GetResponse( request );

            return JsonConvert.DeserializeObject<NowOnAir.Rootobject>( responce );
        }

        public async Task<string> GetResponse( string requestUri )
        {
            var request = WebRequest.Create( requestUri );

            var response = await request.GetResponseAsync();
            using ( var stream = response.GetResponseStream() ) {
                if ( stream == null ) {
                    return string.Empty;
                }

                using ( var reader = new StreamReader( stream, Encoding.UTF8 ) ) {
                    return reader.ReadToEnd();
                }
            }
        }
    }
}
