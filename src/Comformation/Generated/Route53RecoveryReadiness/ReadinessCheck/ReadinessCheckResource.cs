using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53RecoveryReadiness.ReadinessCheck
{
    /// <summary>
    /// AWS::Route53RecoveryReadiness::ReadinessCheck
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53recoveryreadiness-readinesscheck.html
    /// </summary>
    public class ReadinessCheckResource : ResourceBase
    {
        public class ReadinessCheckProperties
        {
            /// <summary>
            /// ResourceSetName
            /// The name of the resource set to check.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ResourceSetName { get; set; }

            /// <summary>
            /// ReadinessCheckName
            /// The name of the readiness check to create.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ReadinessCheckName { get; set; }

            /// <summary>
            /// Tags
            /// A collection of tags associated with a resource.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::Route53RecoveryReadiness::ReadinessCheck";

        public ReadinessCheckProperties Properties { get; } = new ReadinessCheckProperties();

    }

    public static class ReadinessCheckAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ReadinessCheckArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("ReadinessCheckArn");
    }
}
