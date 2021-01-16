using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElastiCache.ParameterGroup
{
    /// <summary>
    /// AWS::ElastiCache::ParameterGroup
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-parameter-group.html
    /// </summary>
    public class ParameterGroupResource : ResourceBase
    {
        public class ParameterGroupProperties
        {
            /// <summary>
            /// CacheParameterGroupFamily
            /// The name of the cache parameter group family that this cache parameter group is compatible with.
            /// Valid values are: memcached1. 4 | memcached1. 5 | memcached1. 6 | redis2. 6 | redis2. 8 | redis3. 2
            /// | redis4. 0 | redis5. 0 | redis6. x
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> CacheParameterGroupFamily { get; set; }

            /// <summary>
            /// Description
            /// The description for this cache parameter group.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Properties
            /// A comma-delimited list of parameter name/value pairs. For more information, see
            /// ModifyCacheParameterGroup in the Amazon ElastiCache API Reference Guide.
            /// For example:
            /// &quot;Properties&quot; : { &quot;cas_disabled&quot; : &quot;1&quot;, &quot;chunk_size_growth_factor&quot; : &quot;1. 02&quot; }
            /// Required: No
            /// Type: Map of String
            /// Update requires: No interruption
            /// </summary>
            public Dictionary<string, Union<string, IntrinsicFunction>> Properties { get; set; }

        }

        public string Type { get; } = "AWS::ElastiCache::ParameterGroup";

        public ParameterGroupProperties Properties { get; } = new ParameterGroupProperties();

    }
}
