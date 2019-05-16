using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.RDS.DBSecurityGroup
{
    /// <summary>
    /// AWS::RDS::DBSecurityGroup
    /// The AWS::RDS::DBSecurityGroup resource creates or updates an Amazon RDS DB security group.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-security-group.html
    /// </summary>
    public class DBSecurityGroupResource : ResourceBase
    {
        public class DBSecurityGroupProperties
        {
            /// <summary>
            /// DBSecurityGroupIngress
            /// Ingress rules to be applied to the DB security group.
            /// Required: Yes
            /// Type: List of Ingress
            /// Update requires: No interruption
            /// </summary>
			public List<Ingress> DBSecurityGroupIngress { get; set; }

            /// <summary>
            /// EC2VpcId
            /// The identifier of an Amazon VPC. This property indicates the VPC that this DB security group belongs
            /// to.
            /// Important The EC2VpcId property is for backward compatibility with older regions, and is no longer
            /// recommended for providing security information to an RDS DB instance.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> EC2VpcId { get; set; }

            /// <summary>
            /// GroupDescription
            /// Provides the description of the DB Security Group.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> GroupDescription { get; set; }

            /// <summary>
            /// Tags
            /// Tags to assign to the DB security group.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::RDS::DBSecurityGroup";

        public DBSecurityGroupProperties Properties { get; } = new DBSecurityGroupProperties();

    }
}
