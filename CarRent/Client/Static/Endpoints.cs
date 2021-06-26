using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Client.Static
{
    public class Endpoints
    {
        public static string Prefix = "api";

        public static string MakesEndpoint = $"{Prefix}/makes";
        public static string ModelsEndpoint = $"{Prefix}/models";
        public static string ColorsEndpoint = $"{Prefix}/colors";
        public static string BookingsEndpoint = $"{Prefix}/bookings";
        public static string CustomersEndpoint = $"{Prefix}/customers";
        public static string VehiclesEndpoint = $"{Prefix}/vehicles";
    }
}
