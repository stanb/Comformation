using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.RDS.DBSecurityGroupIngress
{
    /// <summary>
    /// AWS::RDS::DBSecurityGroupIngress
    /// The AWS::RDS::DBSecurityGroupIngress resource enables ingress to a DB security group using one of two forms of
    /// authorization. First, you can add EC2 or VPC security groups to the DB security group if the application using
    /// the database is running on EC2 or VPC instances. Second, IP ranges are available if the application accessing
    /// your database is running on the Internet.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-security-group-ingress.html
    /// </summary>
    public class DBSecurityGroupIngressResource : ResourceBase
    {
        public class DBSecurityGroupIngressProperties
        {
            /// <summary>
            /// CIDRIP
            /// The IP range to authorize.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> CIDRIP { get; set; }

            /// <summary>
            /// DBSecurityGroupName
            /// The name of the DB Security Group to add authorization to.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> DBSecurityGroupName { get; set; }

            /// <summary>
            /// EC2SecurityGroupId
            /// Id of the EC2 Security Group to authorize. For VPC DB Security Groups, EC2SecurityGroupId must be
            /// provided. Otherwise, EC2SecurityGroupOwnerId and either EC2SecurityGroupName or EC2SecurityGroupId
            /// must be provided.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> EC2SecurityGroupId { get; set; }

            /// <summary>
            /// EC2SecurityGroupName
            /// Name of the EC2 Security Group to authorize. For VPC DB Security Groups, EC2SecurityGroupId must be
            /// provided. Otherwise, EC2SecurityGroupOwnerId and either EC2SecurityGroupName or EC2SecurityGroupId
            /// must be provided.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> EC2SecurityGroupName { get; set; }

            /// <summary>
            /// EC2SecurityGroupOwnerId
            /// AWS Account Number of the owner of the EC2 Security Group specified in the EC2SecurityGroupName
            /// parameter. The AWS Access Key ID is not an acceptable value. For VPC DB Security Groups,
            /// EC2SecurityGroupId must be provided. Otherwise, EC2SecurityGroupOwnerId and either
            /// EC2SecurityGroupName or EC2SecurityGroupId must be provided.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> EC2SecurityGroupOwnerId { get; set; }

        }

        public string Type { get; } = "AWS::RDS::DBSecurityGroupIngress";

        public DBSecurityGroupIngressProperties Properties { get; } = new DBSecurityGroupIngressProperties();

    }
}
