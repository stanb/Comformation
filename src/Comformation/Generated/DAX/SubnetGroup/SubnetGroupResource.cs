using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.DAX.SubnetGroup
{
    /// <summary>
    /// AWS::DAX::SubnetGroup
    /// Use the AWS CloudFormation AWS::DAX::SubnetGroup resource to create a subnet group for use with DAX (DynamoDB
    /// Accelerator).
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
            /// Update requires: Updates are not supported.
            /// </summary>
			public Union<string, IntrinsicFunction> SubnetGroupName { get; set; }

            /// <summary>
            /// SubnetIds
            /// A list of subnets associated with the subnet group.
            /// Required: No
            /// Type: List of String values;
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> SubnetIds { get; set; }

        }
    
        public string Type { get; } = "AWS::DAX::SubnetGroup";
        
        public SubnetGroupProperties Properties { get; } = new SubnetGroupProperties();

    }
}
