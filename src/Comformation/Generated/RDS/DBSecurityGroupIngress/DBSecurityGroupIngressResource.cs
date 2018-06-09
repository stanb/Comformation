using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.RDS.DBSecurityGroupIngress
{
    /// <summary>
    /// AWS::RDS::DBSecurityGroupIngress
    /// The AWS::RDS::DBSecurityGroupIngress type enables ingress to a DBSecurityGroup using one of two forms of
    /// authorization. First, EC2 or VPC security groups can be added to the DBSecurityGroup if the application using
    /// the database is running on EC2 or VPC instances. Second, IP ranges are available if the application accessing
    /// your database is running on the Internet. For more information about DB security groups, see Working with DB
    /// security groups
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-security-group-ingress.html
    /// </summary>
    public class DBSecurityGroupIngressResource : ResourceBase
    {
        public class DBSecurityGroupIngressProperties
        {
            /// <summary>
            /// CIDRIP
            /// The IP range to authorize.
            /// For an overview of CIDR ranges, go to the Wikipedia Tutorial.
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> CIDRIP { get; set; }

            /// <summary>
            /// DBSecurityGroupName
            /// The name (ARN) of the AWS::RDS::DBSecurityGroup to which this ingress will be added.
            /// Type: String
            /// Required: Yes
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> DBSecurityGroupName { get; set; }

            /// <summary>
            /// EC2SecurityGroupId
            /// The ID of the VPC or EC2 security group to authorize.
            /// For VPC DB security groups, use EC2SecurityGroupId. For EC2 security groups, use
            /// EC2SecurityGroupOwnerId and either EC2SecurityGroupName or EC2SecurityGroupId.
            /// Type: String
            /// Required: No
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> EC2SecurityGroupId { get; set; }

            /// <summary>
            /// EC2SecurityGroupName
            /// The name of the EC2 security group to authorize.
            /// For VPC DB security groups, use EC2SecurityGroupId. For EC2 security groups, use
            /// EC2SecurityGroupOwnerId and either EC2SecurityGroupName or EC2SecurityGroupId.
            /// Type: String
            /// Required: No
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> EC2SecurityGroupName { get; set; }

            /// <summary>
            /// EC2SecurityGroupOwnerId
            /// The AWS Account Number of the owner of the EC2 security group specified in the EC2SecurityGroupName
            /// parameter. The AWS Access Key ID is not an acceptable value.
            /// For VPC DB security groups, use EC2SecurityGroupId. For EC2 security groups, use
            /// EC2SecurityGroupOwnerId and either EC2SecurityGroupName or EC2SecurityGroupId.
            /// Type: String
            /// Required: No
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> EC2SecurityGroupOwnerId { get; set; }

        }
    
        public string Type { get; } = "AWS::RDS::DBSecurityGroupIngress";
        
        public DBSecurityGroupIngressProperties Properties { get; } = new DBSecurityGroupIngressProperties();
    }
}
