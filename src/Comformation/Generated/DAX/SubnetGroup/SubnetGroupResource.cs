using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.DAX.SubnetGroup
{
    /// <summary>
    /// AWS::DAX::SubnetGroup
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dax-subnetgroup.html
    /// </summary>
    public class SubnetGroupResource : ResourceBase
    {
        public class SubnetGroupProperties
        {
            /// <summary>
            /// Description
            /// The description of the subnet group.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// SubnetGroupName
            /// The name of the subnet group.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> SubnetGroupName { get; set; }

            /// <summary>
            /// SubnetIds
            /// A list of VPC subnet IDs for the subnet group.
            /// Required: Yes
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> SubnetIds { get; set; }

        }

        public string Type { get; } = "AWS::DAX::SubnetGroup";

        public SubnetGroupProperties Properties { get; } = new SubnetGroupProperties();

    }
}
