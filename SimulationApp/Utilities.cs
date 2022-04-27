using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationApp
{
  class Utilities
  {
    public static string URISource { get; set; }

    /// <summary>
    /// Creates new navigation URI for page passsed in.
    /// </summary>
    /// <param name="pageToNavigateTo">URI of page to navigate to</param>
    /// <returns></returns>
    public static Uri GenerateNewUri(string pageToNavigateTo)
    {
      // Set passed in page source to property.
      URISource = pageToNavigateTo;

      // Create a new relative URI with property containing page source.
      Uri NewUri = new Uri(URISource, UriKind.Relative);

      // Return new URI.
      return NewUri;
    }

  }
}
