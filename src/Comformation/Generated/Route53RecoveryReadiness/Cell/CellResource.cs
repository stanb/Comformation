using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53RecoveryReadiness.Cell
{
    /// <summary>
    /// AWS::Route53RecoveryReadiness::Cell
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53recoveryreadiness-cell.html
    /// </summary>
    public class CellResource : ResourceBase
    {
        public class CellProperties
        {
            /// <summary>
            /// CellName
            /// The name of the cell to create.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> CellName { get; set; }

            /// <summary>
            /// Cells
            /// A list of cell Amazon Resource Names (ARNs) contained within this cell, for use in nested cells. For
            /// example, Availability Zones within specific Regions.
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

        public string Type { get; } = "AWS::Route53RecoveryReadiness::Cell";

        public CellProperties Properties { get; } = new CellProperties();

    }

    public static class CellAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CellArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("CellArn");
        public static readonly ResourceAttribute<List<Union<string, IntrinsicFunction>>> ParentReadinessScopes = new ResourceAttribute<List<Union<string, IntrinsicFunction>>>("ParentReadinessScopes");
    }
}
