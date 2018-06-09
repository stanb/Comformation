using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElastiCache.SecurityGroupIngress
{
    /// <summary>
    /// AWS::ElastiCache::SecurityGroupIngress
    /// The AWS::ElastiCache::SecurityGroupIngress type authorizes ingress to a cache security group from hosts in
    /// specified Amazon EC2 security groups. For more information about ElastiCache security group ingress, go to
    /// AuthorizeCacheSecurityGroupIngress in the Amazon ElastiCache API Reference Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-security-group-ingress.html
    /// </summary>
    public class SecurityGroupIngressResource : ResourceBase
    {
        public class SecurityGroupIngressProperties
        {
            /// <summary>
            /// CacheSecurityGroupName
            /// The name of the Cache Security Group to authorize.
            /// Type: String
            /// Required: Yes
            /// Update requires: Updates are not supported.
            /// </summary>
			public Union<string, IntrinsicFunction> CacheSecurityGroupName { get; set; }

            /// <summary>
            /// EC2SecurityGroupName
            /// Name of the EC2 Security Group to include in the authorization.
            /// Type: String
            /// Required: Yes
            /// Update requires: Updates are not supported.
            /// </summary>
			public Union<string, IntrinsicFunction> EC2SecurityGroupName { get; set; }

            /// <summary>
            /// EC2SecurityGroupOwnerId
            /// Specifies the AWS Account ID of the owner of the EC2 security group specified in the
            /// EC2SecurityGroupName property. The AWS access key ID is not an acceptable value.
            /// Type: String
            /// Required: No
            /// Update requires: Updates are not supported.
            /// </summary>
			public Union<string, IntrinsicFunction> EC2SecurityGroupOwnerId { get; set; }

        }
    
        public string Type { get; } = "AWS::ElastiCache::SecurityGroupIngress";
        
        public SecurityGroupIngressProperties Properties { get; } = new SecurityGroupIngressProperties();
    }
}
