#region Namespaces

using System.Net;

#endregion

namespace IAmBored.Utilities
{
    public static class InternetUtilities
    {
        /// <summary>
        ///     Checks for internet connection.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <param name="timeoutMs">The timeout ms.</param>
        /// <returns>The <see cref="bool" />.</returns>
        public static bool CheckForInternetConnection(string url, int timeoutMs = 10000)
        {
            if (string.IsNullOrEmpty(url))
            {
                return false;
            }

            try
            {
                var request = (HttpWebRequest) WebRequest.Create(url);
                request.KeepAlive = false;
                request.Timeout = timeoutMs;
                using (var response = (HttpWebResponse) request.GetResponse())
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}