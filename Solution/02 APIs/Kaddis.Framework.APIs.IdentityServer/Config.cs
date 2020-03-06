﻿using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Kaddis.Framework.APIs.IdentityServer
{
    public class Config
    {
        public static IEnumerable<ApiResource> GetAllApiResorces()
        {
            return new List<ApiResource>()
            {
                new ApiResource("testapi", "Dahampasal Api")
            };
        }

        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>()
            {
                new Client()
                {
                    ClientId = "client",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets =
                    {
                        new Secret("secret".Sha256())
                    },
                    AllowedScopes = { "testapi" }
                }
            };
        }
    }
}
