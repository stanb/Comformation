using System;
using Xunit;
using Amazon.Auth.AccessControlPolicy;
using Statement = Amazon.Auth.AccessControlPolicy.Statement;
using System.Collections.Generic;
using Amazon;
using Comformation.IntrinsicFunctions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Comformation.Tests
{
    public class TemplateSerializationShould
    {
        private static readonly JsonSerializerSettings SerializerSettings;
        
        static TemplateSerializationShould()
        {
            SerializerSettings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                NullValueHandling = NullValueHandling.Ignore,
                Converters = { new RawJsonConverter() }
            };
        }
        
        [Fact]
        public void SerializeConditions()
        {
            var conditions = new Conditions
            {
                new Condition
                {
                    LogicalId = "CreateProdResources",
                    IntrinsicFunction = Fn.Equals(Fn.Ref("EnvType"), "prod") 
                }
            };
            
            var json = JsonConvert.SerializeObject(conditions, SerializerSettings);

            var actual = JToken.Parse(json);
            var expected = JToken.Parse("{\"CreateProdResources\" : {\"Fn::Equals\" : [{\"Ref\" : \"EnvType\"}, \"prod\"]}}");
            
            Assert.True(JToken.DeepEquals(actual, expected));
        }
        
        [Fact]
        public void SerializeMappings()
        {
            var mappings = new Mappings
            {
                new Mapping
                {
                    Name = "Mapping1",
                    Maps =
                    {
                        new RegionMap
                        {
                            Region = RegionEndpoint.EUWest1,
                            Map =
                            {
                                { "item1", "value1" },
                                { "item2", "value2" }
                            }
                        },
                        new RegionMap
                        {
                            Region = RegionEndpoint.EUWest2,
                            Map =
                            {
                                { "item1", "value1" },
                                { "item2", "value2" }
                            }
                        }
                    }
                }
            };
            
            var json = JsonConvert.SerializeObject(mappings, SerializerSettings);
            
            var expected = JToken.Parse("{\"Mapping1\": {\"eu-west-1\": {\"item1\": \"value1\",\"item2\": \"value2\"},\"eu-west-2\": {\"item1\": \"value1\",\"item2\": \"value2\"}}}");
            var actual = JToken.Parse(json);
            Assert.True(JToken.DeepEquals(actual, expected));
        }

        [Fact]
        public void SerializeMixedMappings()
        {
            var mappings = new Mappings
            {
                new Mapping
                {
                    Name = "environments",
                    Regions = {
                        new RegionMap
                        {
                            Region = RegionEndpoint.EUWest1,
                            Map =
                            {
                                { "item1", "value1" },
                                { "item2", "value2" }
                            }
                        },
                        new RegionMap
                        {
                            Region = RegionEndpoint.EUWest2,
                            Map =
                            {
                                { "item1", "value1" },
                                { "item2", "value2" }
                            }
                        },
                    },
                    Maps = {
                        new NamedMap
                        {
                            Name = "DEV",
                            Map =
                            {
                                { "key1", "dev-val1" },
                                { "key2", "dev-val2" }
                            }
                        },
                        new NamedMap
                        {
                            Name = "PROD",
                            Map = {
                                { "key1", "prod-val1" },
                                { "key2", "prod-val2" }
                            }
                        },
                        new RegionMap
                        {
                            Region = RegionEndpoint.USEast1,
                            Map =
                            {
                                { "key1", "useast1-val1" },
                                { "key2", "useast1-val2" }
                            }
                        }
                    }
                }
            };

            var json = JsonConvert.SerializeObject(mappings, SerializerSettings);
            var expected = JToken.Parse("{\"environments\": {\"DEV\": {\"key1\": \"dev-val1\",\"key2\": \"dev-val2\"},\"PROD\": {\"key1\": \"prod-val1\",\"key2\": \"prod-val2\"},\"us-east-1\": {\"key1\": \"useast1-val1\",\"key2\": \"useast1-val2\"},\"eu-west-1\": {\"item1\": \"value1\",\"item2\": \"value2\"},\"eu-west-2\": {\"item1\": \"value1\",\"item2\": \"value2\"}}}");
            var actual = JToken.Parse(json);
            Assert.True(JToken.DeepEquals(actual, expected));
        }

        [Fact]
        public void SerializeOutputs()
        {
            var outputs = new Outputs
            {
                new Output
                {
                    LogicalId = "Output1",
                    Description = "Output 1",
                    Value = Fn.GetAtt("SomeRole", IAM.Role.RoleAttributes.Arn)
                },
                new Output
                {
                    LogicalId = "Output2",
                    Description = "Output 2",
                    Value = "bla bla bla"
                }
            };
            
            var json = JsonConvert.SerializeObject(outputs, SerializerSettings);
            
            var actual = JToken.Parse(json);
            var expected = JToken.Parse("{\"Output1\": {\"Description\": \"Output 1\",\"Value\": {\"Fn::GetAtt\": [\"SomeRole\",\"Arn\"]}},\"Output2\": {\"Description\": \"Output 2\",\"Value\": \"bla bla bla\"}}");
            
            Assert.True(JToken.DeepEquals(actual, expected));
        }
        
        [Fact]
        public void SerializeTemplate()
        {
            var template = new Template
            {
                Description = "Grants access to this accounts resources from trusted account",
                Parameters = new Parameters
                {
                    new Parameter 
                    {
                        LogicalId = "TrustedAccount",
                        Type = ParameterType.Number,
                        MaxValue = 999999999999
                    },
                    new Parameter
                    {
                        LogicalId = "ExternalId", 
                        Type = ParameterType.String,
                        MinLength = 2,
                        MaxLength = 256,
                        AllowedPattern = "[\\w+=,.@:\\/-]*"
                    }
                },
                Resources = new Resources
                {
                    new IAM.Role.RoleResource
                    {
                        LogicalId = "TrustRole", 
                        Properties =
                        {
                            AssumeRolePolicyDocument = JToken.Parse(new Policy
                            {
                                Version = "2012-10-17",
                                Statements = 
                                {
                                    new Statement(Statement.StatementEffect.Allow) {
                                        Actions = {new ActionIdentifier("sts:AssumeRole")},
                                        Conditions =
                                        {
                                            new Amazon.Auth.AccessControlPolicy.Condition
                                            {
                                                Type = "StringEquals",
                                                ConditionKey = "sts:ExternalId",
                                                Values = new [] { Fn.Ref("ExternalId").ToString() }
                                            }
                                        },
                                        Principals = 
                                        {
                                            // Should be parsed with RawJsonConverter
                                            new Principal(
                                                //"{ \"Fn::Sub\": [ \"arn:aws:iam::${TrustedAccount}:root\", { \"TrustedAccount\": { \"Ref\": \"TrustedAccount\" } } ] }")
                                                Fn.Sub("arn:aws:iam::${TrustedAccount}:root", new Sub.Item("TrustedAccount", Fn.Ref("TrustedAccount")))
                                                    .ToString())
                                        }
                                    }
                                }
                            }.ToJson()),
                            Path = "/",
                            ManagedPolicyArns = new List<Union<string, IntrinsicFunction>>
                            {
                                "arn:aws:iam::aws:policy/PowerUserAccess",
                                "arn:aws:iam::aws:policy/IAMFullAccess"
                            }
                        }
                    }
                },
                Outputs = new Outputs
                {
                    new Output
                    {
                        LogicalId = "RoleArn",
                        Value = Fn.GetAtt("SomeRole", IAM.Role.RoleAttributes.Arn)
                    }
                }
            };

            var json = template.ToJson();
        }
    }
}
