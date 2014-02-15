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
        const string ApiEndPoint = @"http://api.nhk.or.jp/v1/pg";
        string apiKey = string.Empty;

        public NhkTimetable( string apiKey )
        {
            this.apiKey = apiKey;
        }

        public async Task<ProgramList.Rootobject> GetProgramList( NhkArea area, NhkService serivce, DateTime time )
        {
            var responce = await GetResponse( GetProgramListUri(area, serivce, time ) );

            return JsonConvert.DeserializeObject<ProgramList.Rootobject>( responce );
        }

        public async Task<ProgramGenre.Rootobject> GetProgramGenre( NhkArea area, NhkService serivce, NhkGenre genre, DateTime time )
        {
            var responce = await GetResponse( GetProgramGenreUri( area, serivce, genre, time ) );

            return JsonConvert.DeserializeObject<ProgramGenre.Rootobject>( responce );
        }

        public async Task<ProgramInfo.Rootobject> GetProgramInfo( NhkArea area, NhkService serivce, string id )
        {
            var responce = await GetResponse( GetProgramInfoUri( area, serivce, id ) );

            return JsonConvert.DeserializeObject<ProgramInfo.Rootobject>( responce );
        }

        public async Task<NowOnAir.Rootobject> GetNowOnAir( NhkArea area, NhkService serivce )
        {
            var responce = await GetResponse( GetNowOnAirUri( area, serivce ) );

            return JsonConvert.DeserializeObject<NowOnAir.Rootobject>( responce );
        }

        public string GetProgramListUri( NhkArea area, NhkService serivce, DateTime time )
        {
            return string.Format( @"{0}/list/{1}/{2}/{3}.json?key={4}",
                ApiEndPoint, area.ToCode(), serivce.ToCode(), time.ToString( @"yyyy-MM-dd" ), apiKey );
        }

        public string GetProgramGenreUri( NhkArea area, NhkService serivce, NhkGenre genre, DateTime time )
        {
            return string.Format( @"{0}/genre/{1}/{2}/{3:0000}/{4}.json?key={5}",
                ApiEndPoint, area.ToCode(), serivce.ToCode(), (int)genre, time.ToString( @"yyyy-MM-dd" ), apiKey );
        }

        public string GetProgramInfoUri( NhkArea area, NhkService serivce, string id )
        {
            return string.Format( @"{0}/info/{1}/{2}/{3}.json?key={4}",
                ApiEndPoint, area.ToCode(), serivce.ToCode(), id, apiKey );
        }

        public string GetNowOnAirUri( NhkArea area, NhkService serivce )
        {
            return string.Format( @"{0}/now/{1}/{2}.json?key={3}",
                ApiEndPoint, area.ToCode(), serivce.ToCode(), apiKey );
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
