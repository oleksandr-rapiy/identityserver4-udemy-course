﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer4.Models;
using IdentityServer4.Test;

namespace IdentityServerCourse.IdentityServer.Configurations
{
    public static class IdentityConfiguration
    {
        public static List<TestUser> GetUsers()
        {
            return new List<TestUser>()
            {
                new TestUser()
                {
                    SubjectId = "1",
                    Username = "Jon",
                    Password = "rainbow"
                },
                new TestUser()
                {
                    SubjectId = "2",
                    Username = "Bob",
                    Password = "rainbow"
                }
            };
        }


        public static IEnumerable<ApiResource> GetAllApiResources()
        {
            return new List<ApiResource>()
            {
                new ApiResource("customerAPI", "Customer API resources")
            };
        }

        public static IEnumerable<Client> GetAllClients()
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
                    AllowedScopes = { "customerAPI" }
                },
                new Client()
                {
                    ClientId = "client2.0",
                    AllowedGrantTypes = GrantTypes.ResourceOwnerPassword,
                    ClientSecrets =
                    {
                        new Secret("secret".Sha256())

                    },
                    AllowedScopes = { "customerAPI" }
                }
            };
        }

        public static IEnumerable<ApiScope> GetAllApiScopes()
        {
            return new List<ApiScope>()
            {
                new ApiScope("customerAPI")
            };
        }
    }

}
