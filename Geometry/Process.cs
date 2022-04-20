using ConsoleApp.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleApp.Geometry
{
    public class Process
    {
        public static async Task PointInsidePolygon()
        {
            var client = new HttpClient();

            // Create the HttpContent for the form to be posted.
            var requestContent = new FormUrlEncodedContent(new[] { new KeyValuePair<string, string>("objectId", "0cbd2824-2cea-48ca-a3da-3991a412bbf3") });

            // Get the response.
            HttpResponseMessage response = await client.GetAsync("https://api.dev.stay.tui.com/geoservices/backoffice/geoobject?objectId=0cbd2824-2cea-48ca-a3da-3991a412bbf3");

            // Get the response content.
            HttpContent responseContent = response.Content;

            // Get the stream of the content.
            using (var reader = new StreamReader(await responseContent.ReadAsStreamAsync()))
            {
                var responseData = await reader.ReadToEndAsync();
                var geoInfos = JsonConvert.DeserializeObject<List<ObjectGeotree>>(responseData);

                foreach (var geoInfo in geoInfos)
                {
                    var polygon = geoInfo.Bbox;

                    var gf = NetTopologySuite.NtsGeometryServices.Instance.CreateGeometryFactory();

                    var geoItems = polygon.Coordinates.FirstOrDefault().Select(x => new NetTopologySuite.Geometries.Coordinate(x.ElementAt(0), x.ElementAt(1)));

                    var ply1 = gf.CreatePolygon(geoItems.ToArray());

                    var point = gf.CreatePoint(new NetTopologySuite.Geometries.Coordinate(7.5404, 53.4837));


                }
            }
        }
    }
}