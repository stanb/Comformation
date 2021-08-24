using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElastiCache.SecurityGroup
{
    /// <summary>
    /// AWS::ElastiCache::SecurityGroup
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-security-group.html
    /// </summary>
    public class SecurityGroupResource : ResourceBase
    {
        public class SecurityGroupProperties
        {
            /// <summary>
            /// Description
            /// A description for the cache security group.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Tags
            /// A tag that can be added to an ElastiCache security group. Tags are composed of a Key/Value pair. You
            /// can use tags to categorize and track all your security groups. A tag with a null Value is permitted.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::ElastiCache::SecurityGroup";

        public SecurityGroupProperties Properties { get; } = new SecurityGroupProperties();

    }
}
