using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EventSchemas.RegistryPolicy
{
    /// <summary>
    /// AWS::EventSchemas::RegistryPolicy
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eventschemas-registrypolicy.html
    /// </summary>
    public class RegistryPolicyResource : ResourceBase
    {
        public class RegistryPolicyProperties
        {
            /// <summary>
            /// Policy
            /// A resource-based policy.
            /// Required: Yes
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Policy { get; set; }

            /// <summary>
            /// RegistryName
            /// The name of the registry.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> RegistryName { get; set; }

            /// <summary>
            /// RevisionId
            /// The revision ID of the policy.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> RevisionId { get; set; }

        }

        public string Type { get; } = "AWS::EventSchemas::RegistryPolicy";

        public RegistryPolicyProperties Properties { get; } = new RegistryPolicyProperties();

    }

    public static class RegistryPolicyAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
    }
}
