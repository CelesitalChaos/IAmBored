#region Namespaces

using System.Net;

#endregion

namespace IAmBored.Utilities
{
    public class BoredAPI
    {
        /// <summary>
        ///     The URL address.
        /// </summary>
        public const string URL = "http://www.boredapi.com/api/activity/";

        /// <summary>
        ///     Downloads the json.
        /// </summary>
        /// <returns>The <see cref="string" />.</returns>
        public static string DownloadJSON()
        {
            string json;

            using (WebClient wc = new WebClient())
            {
                json = wc.DownloadString(URL);
            }

            return json;
        }

        /// <summary>
        ///     Gets the module.
        /// </summary>
        /// <returns>The <see cref="BoredModule" />.</returns>
        public static BoredModule GetModule()
        {
            var json = DownloadJSON();

            BoredModule module = new BoredModule();

            module.LoadModule(json);

            return module;
        }
    }
}