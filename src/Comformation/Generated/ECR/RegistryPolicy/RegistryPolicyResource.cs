using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECR.RegistryPolicy
{
    /// <summary>
    /// AWS::ECR::RegistryPolicy
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecr-registrypolicy.html
    /// </summary>
    public class RegistryPolicyResource : ResourceBase
    {
        public class RegistryPolicyProperties
        {
            /// <summary>
            /// PolicyText
            /// The JSON policy text for your registry.
            /// Required: Yes
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> PolicyText { get; set; }

        }

        public string Type { get; } = "AWS::ECR::RegistryPolicy";

        public RegistryPolicyProperties Properties { get; } = new RegistryPolicyProperties();

    }

    public static class RegistryPolicyAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> RegistryId = new ResourceAttribute<Union<string, IntrinsicFunction>>("RegistryId");
    }
}
