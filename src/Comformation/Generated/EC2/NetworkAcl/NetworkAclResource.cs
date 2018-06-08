using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.NetworkAcl
{
    /// <summary>
    /// AWS::EC2::NetworkAcl
    /// Creates a new network ACL in a VPC.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-acl.html
    /// </summary>
    public class NetworkAclResource : ResourceBase
    {
        public class NetworkAclProperties
        {
            /// <summary>
            /// Tags
            /// An arbitrary set of tags (key–value pairs) for this ACL.
            /// Required: No
            /// Type: AWS CloudFormation Resource Tags
            /// Update requires: No interruption.
            /// </summary>
			public Union<List<Tag>, IntrinsicFunction> Tags { get; set; }

            /// <summary>
            /// VpcId
            /// The ID of the VPC where the network ACL will be created.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> VpcId { get; set; }

        }
    
        public string Type { get; } = "AWS::EC2::NetworkAcl";
        
        public NetworkAclProperties Properties { get; } = new NetworkAclProperties();
    }
}
