using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.RDS.DBSecurityGroup
{
    /// <summary>
    /// AWS::RDS::DBSecurityGroup
    /// The AWS::RDS::DBSecurityGroup type is used to create or update an Amazon RDS DB Security Group. For more
    /// information about DB security groups, see Working with DB Security Groups in the Amazon Relational Database
    /// Service Developer Guide. For details on the settings for DB security groups, see CreateDBSecurityGroup.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-security-group.html
    /// </summary>
    public class DBSecurityGroupResource : ResourceBase
    {
        public class DBSecurityGroupProperties
        {
            /// <summary>
            /// DBSecurityGroupIngress
            /// Network ingress authorization for an Amazon EC2 security group or an IP address range.
            /// Type: List of RDS Security Group Rules.
            /// Required: Yes
            /// Update requires: No interruption
            /// </summary>
			public List<Ingress> DBSecurityGroupIngress { get; set; }

            /// <summary>
            /// EC2VpcId
            /// The Id of the VPC. Indicates which VPC this DB Security Group should belong to.
            /// Important The EC2VpcId property exists only for backwards compatibility with older regions and is no
            /// longer recommended for providing security information to an RDS DB instance. Instead, use
            /// VPCSecurityGroups.
            /// Type: String
            /// Required: Conditional. Must be specified to create a DB Security Group for a VPC; may not be
            /// specified otherwise.
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> EC2VpcId { get; set; }

            /// <summary>
            /// GroupDescription
            /// Description of the security group.
            /// Type: String
            /// Required: Yes
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> GroupDescription { get; set; }

            /// <summary>
            /// Tags
            /// The tags that you want to attach to the Amazon RDS DB security group.
            /// Required: No
            /// Type: A list of resource tags.
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

        }
    
        public string Type { get; } = "AWS::RDS::DBSecurityGroup";
        
        public DBSecurityGroupProperties Properties { get; } = new DBSecurityGroupProperties();

    }
}
