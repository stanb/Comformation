using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53RecoveryReadiness.RecoveryGroup
{
    /// <summary>
    /// AWS::Route53RecoveryReadiness::RecoveryGroup
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53recoveryreadiness-recoverygroup.html
    /// </summary>
    public class RecoveryGroupResource : ResourceBase
    {
        public class RecoveryGroupProperties
        {
            /// <summary>
            /// RecoveryGroupName
            /// The name of the recovery group to create.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> RecoveryGroupName { get; set; }

            /// <summary>
            /// Cells
            /// A list of the cell Amazon Resource Names (ARNs) in the recovery group.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> Cells { get; set; }

            /// <summary>
            /// Tags
            /// A collection of tags associated with a resource.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::Route53RecoveryReadiness::RecoveryGroup";

        public RecoveryGroupProperties Properties { get; } = new RecoveryGroupProperties();

    }

    public static class RecoveryGroupAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> RecoveryGroupArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("RecoveryGroupArn");
    }
}
