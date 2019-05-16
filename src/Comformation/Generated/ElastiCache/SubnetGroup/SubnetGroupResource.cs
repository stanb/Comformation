using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElastiCache.SubnetGroup
{
    /// <summary>
    /// AWS::ElastiCache::SubnetGroup
    /// Creates a cache subnet group. For more information about cache subnet groups, go to Cache Subnet Groups in the
    /// Amazon ElastiCache User Guide or go to CreateCacheSubnetGroup in the Amazon ElastiCache API Reference Guide.
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

        }

        public string Type { get; } = "AWS::ElastiCache::SubnetGroup";

        public SubnetGroupProperties Properties { get; } = new SubnetGroupProperties();

    }
}
