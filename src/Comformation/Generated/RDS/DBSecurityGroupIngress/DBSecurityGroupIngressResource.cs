using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.RDS.DBSecurityGroupIngress
{
    /// <summary>
    /// AWS::RDS::DBSecurityGroupIngress
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
            /// The name of the DB security group to add authorization to.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> DBSecurityGroupName { get; set; }

            /// <summary>
            /// EC2SecurityGroupId
            /// Id of the EC2 security group to authorize. For VPC DB security groups, EC2SecurityGroupId must be
            /// provided. Otherwise, EC2SecurityGroupOwnerId and either EC2SecurityGroupName or EC2SecurityGroupId
            /// must be provided.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> EC2SecurityGroupId { get; set; }

            /// <summary>
            /// EC2SecurityGroupName
            /// Name of the EC2 security group to authorize. For VPC DB security groups, EC2SecurityGroupId must be
            /// provided. Otherwise, EC2SecurityGroupOwnerId and either EC2SecurityGroupName or EC2SecurityGroupId
            /// must be provided.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> EC2SecurityGroupName { get; set; }

            /// <summary>
            /// EC2SecurityGroupOwnerId
            /// AWS account number of the owner of the EC2 security group specified in the EC2SecurityGroupName
            /// parameter. The AWS access key ID isn&#39;t an acceptable value. For VPC DB security groups,
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
