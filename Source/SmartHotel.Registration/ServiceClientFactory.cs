using SmartHotel.Registration.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartHotel.Registration
{
    public static class ServiceClientFactory
    {
        public static ServiceClient NewServiceClient()
        {
            var client = new ServiceClient();
            var uri = Environment.GetEnvironmentVariable("WcfServiceUri");

            if (!string.IsNullOrEmpty(uri))
            {
                System.Diagnostics.Trace.TraceInformation("'WcfServiceUri' env var is: " + uri.ToString());
                client.Endpoint.Address = new System.ServiceModel.EndpointAddress(uri);
            }

            System.Diagnostics.Trace.TraceInformation("WCF endpoint is: " + client.Endpoint.Address.ToString());

            return client;

        }
    }
}