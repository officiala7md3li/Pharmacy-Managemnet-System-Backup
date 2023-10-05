using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NuGetPackage
{
    class MyClass
    {

        async Task DownloadAsync()
        {

            HttpClient httpClient = new HttpClient();
            await httpClient.GetStringAsync("");
        }

    }
}
