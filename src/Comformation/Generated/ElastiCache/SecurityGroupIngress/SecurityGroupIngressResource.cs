using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElastiCache.SecurityGroupIngress
{
    /// <summary>
    /// AWS::ElastiCache::SecurityGroupIngress
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-security-group-ingress.html
    /// </summary>
    public class SecurityGroupIngressResource : ResourceBase
    {
        public class SecurityGroupIngressProperties
        {
            /// <summary>
            /// CacheSecurityGroupName
            /// The name of the Cache Security Group to authorize.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> CacheSecurityGroupName { get; set; }

            /// <summary>
            /// EC2SecurityGroupName
            /// Name of the EC2 Security Group to include in the authorization.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> EC2SecurityGroupName { get; set; }

            /// <summary>
            /// EC2SecurityGroupOwnerId
            /// Specifies the AWS Account ID of the owner of the EC2 security group specified in the
            /// EC2SecurityGroupName property. The AWS access key ID is not an acceptable value.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> EC2SecurityGroupOwnerId { get; set; }

        }

        public string Type { get; } = "AWS::ElastiCache::SecurityGroupIngress";

        public SecurityGroupIngressProperties Properties { get; } = new SecurityGroupIngressProperties();

    }
}
