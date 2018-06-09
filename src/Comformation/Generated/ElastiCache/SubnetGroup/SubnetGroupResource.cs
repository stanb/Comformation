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
            /// A name for the cache subnet group. If you don&#39;t specify a name, AWS CloudFormation generates a
            /// unique physical ID. For more information, see Name Type.
            /// Important If you specify a name, you cannot perform updates that require replacement of this
            /// resource. You can perform updates that require no or some interruption. If you must replace the
            /// resource, specify a new name.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> CacheSubnetGroupName { get; set; }

            /// <summary>
            /// Description
            /// The description for the cache subnet group.
            /// Type: String
            /// Required: Yes
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// SubnetIds
            /// The Amazon EC2 subnet IDs for the cache subnet group.
            /// Type: String list
            /// Required: Yes
            /// Update requires: No interruption
            /// </summary>
			public Union<List<string>, IntrinsicFunction> SubnetIds { get; set; }

        }
    
        public string Type { get; } = "AWS::ElastiCache::SubnetGroup";
        
        public SubnetGroupProperties Properties { get; } = new SubnetGroupProperties();
    }
}
