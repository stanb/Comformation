using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.SecurityGroup
{
    /// <summary>
    /// AWS::EC2::SecurityGroup
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-security-group.html
    /// </summary>
    public class SecurityGroupResource : ResourceBase
    {
        public class SecurityGroupProperties
        {
            /// <summary>
            /// GroupDescription
            /// A description for the security group. This is informational only.
            /// 		
            /// Constraints: Up to 255 characters in length
            /// 		
            /// Constraints for EC2-Classic: ASCII characters
            /// 		
            /// Constraints for EC2-VPC: a-z, A-Z, 0-9, spaces, and . _-:/()#,@[]+=&amp;amp;;{}!$*
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> GroupDescription { get; set; }

            /// <summary>
            /// GroupName
            /// The name of the security group.
            /// Constraints: Up to 255 characters in length. Cannot start with sg-.
            /// Constraints for EC2-Classic: ASCII characters
            /// Constraints for EC2-VPC: a-z, A-Z, 0-9, spaces, and . _-:/()#,@[]+=&amp;amp;;{}!$*
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> GroupName { get; set; }

            /// <summary>
            /// SecurityGroupEgress
            /// [VPC only] The outbound rules associated with the security group. There is a short interruption
            /// during which you cannot connect to the security group.
            /// Required: No
            /// Type: List of Egress
            /// Update requires: No interruption
            /// </summary>
            public List<Egress> SecurityGroupEgress { get; set; }

            /// <summary>
            /// SecurityGroupIngress
            /// The inbound rules associated with the security group. There is a short interruption during which you
            /// cannot connect to the security group.
            /// Required: No
            /// Type: List of Ingress
            /// Update requires: No interruption
            /// </summary>
            public List<Ingress> SecurityGroupIngress { get; set; }

            /// <summary>
            /// Tags
            /// Any tags assigned to the security group.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// VpcId
            /// [VPC only] The ID of the VPC for the security group.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> VpcId { get; set; }

        }

        public string Type { get; } = "AWS::EC2::SecurityGroup";

        public SecurityGroupProperties Properties { get; } = new SecurityGroupProperties();

    }

    public static class SecurityGroupAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> GroupId = new ResourceAttribute<Union<string, IntrinsicFunction>>("GroupId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> VpcId = new ResourceAttribute<Union<string, IntrinsicFunction>>("VpcId");
    }
}
