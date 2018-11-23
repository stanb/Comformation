using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElastiCache.ParameterGroup
{
    /// <summary>
    /// AWS::ElastiCache::ParameterGroup
    /// The AWS::ElastiCache::ParameterGroup type creates a new cache parameter group. Cache parameter groups control
    /// the parameters for a cache cluster.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-parameter-group.html
    /// </summary>
    public class ParameterGroupResource : ResourceBase
    {
        public class ParameterGroupProperties
        {
            /// <summary>
            /// CacheParameterGroupFamily
            /// The name of the cache parameter group family that the cache parameter group can be used with.
            /// Required: Yes
            /// Type: String
            /// Update requires: Updates are not supported.
            /// </summary>
			public Union<string, IntrinsicFunction> CacheParameterGroupFamily { get; set; }

            /// <summary>
            /// Description
            /// The description for the Cache Parameter Group.
            /// Required: Yes
            /// Type: String
            /// Update requires: Updates are not supported.
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Properties
            /// A comma-delimited list of parameter name/value pairs. For more information, go to
            /// ModifyCacheParameterGroup in the Amazon ElastiCache API Reference Guide.
            /// Example:
            /// &quot;Properties&quot; : { &quot;cas_disabled&quot; : &quot;1&quot;, &quot;chunk_size_growth_factor&quot; : &quot;1. 02&quot; }
            /// Required: No
            /// Type: Mapping of key-value pairs
            /// Update requires: Updates are not supported.
            /// </summary>
			public Dictionary<string, Union<string, IntrinsicFunction>> Properties { get; set; }

        }

        public string Type { get; } = "AWS::ElastiCache::ParameterGroup";

        public ParameterGroupProperties Properties { get; } = new ParameterGroupProperties();

    }
}
