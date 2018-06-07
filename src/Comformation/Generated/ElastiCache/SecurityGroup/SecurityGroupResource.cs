using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElastiCache.SecurityGroup
{
    /// <summary>
    /// AWS::ElastiCache::SecurityGroup
    /// The AWS::ElastiCache::SecurityGroup resource creates a cache security group. For more information about cache
    /// security groups, go to Cache Security Groups in the Amazon ElastiCache User Guide or go to
    /// CreateCacheSecurityGroup in the Amazon ElastiCache API Reference Guide.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-security-group.html
    /// </summary>
    public class SecurityGroupResource : ResourceBase
    {
        public class SecurityGroupProperties
        {
            /// <summary>
            /// Description
            /// A description for the cache security group.
            /// Type: String
            /// Required: No
            /// Update requires: Updates are not supported.
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-security-group.html#cfn-elasticache-securitygroup-description
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

        }
    
        public string Type { get; } = "AWS::ElastiCache::SecurityGroup";
        
        public SecurityGroupProperties Properties { get; } = new SecurityGroupProperties();
    }
}
