using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.NetworkAcl
{
    /// <summary>
    /// AWS::EC2::NetworkAcl
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-acl.html
    /// </summary>
    public class NetworkAclResource : ResourceBase
    {
        public class NetworkAclProperties
        {
            /// <summary>
            /// Tags
            /// An arbitrary set of tags (key-value pairs) for this ACL.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// VpcId
            /// The ID of the VPC for the network ACL.
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
