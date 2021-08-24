using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElastiCache.SubnetGroup
{
    /// <summary>
    /// AWS::ElastiCache::SubnetGroup
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-subnetgroup.html
    /// </summary>
    public class SubnetGroupResource : ResourceBase
    {
        public class SubnetGroupProperties
        {
            /// <summary>
            /// CacheSubnetGroupName
            /// The name for the cache subnet group. This value is stored as a lowercase string.
            /// Constraints: Must contain no more than 255 alphanumeric characters or hyphens.
            /// Example: mysubnetgroup
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> CacheSubnetGroupName { get; set; }

            /// <summary>
            /// Description
            /// The description for the cache subnet group.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// SubnetIds
            /// The EC2 subnet IDs for the cache subnet group.
            /// Required: Yes
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> SubnetIds { get; set; }

            /// <summary>
            /// Tags
            /// A tag that can be added to an ElastiCache subnet group. Tags are composed of a Key/Value pair. You
            /// can use tags to categorize and track all your subnet groups. A tag with a null Value is permitted.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::ElastiCache::SubnetGroup";

        public SubnetGroupProperties Properties { get; } = new SubnetGroupProperties();

    }
}
