using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElastiCache.ParameterGroup
{
    /// <summary>
    /// AWS::ElastiCache::ParameterGroup
    /// The AWS::ElastiCache::ParameterGroup type creates a new cache parameter group. Cache parameter groups control
    /// the parameters for a cache cluster.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-parameter-group.html
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-parameter-group.html#cfn-elasticache-parametergroup-cacheparametergroupfamily
            /// </summary>
			public Union<string, IntrinsicFunction> CacheParameterGroupFamily { get; set; }

            /// <summary>
            /// Description
            /// The description for the Cache Parameter Group.
            /// Required: Yes
            /// Type: String
            /// Update requires: Updates are not supported.
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-parameter-group.html#cfn-elasticache-parametergroup-description
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Properties
            /// A comma-delimited list of parameter name/value pairs. For more information, go to
            /// ModifyCacheParameterGroup in the Amazon ElastiCache API Reference Guide.
            /// Example:
            /// "Properties" : { "cas_disabled" : "1", "chunk_size_growth_factor" : "1. 02" }
            /// Required: No
            /// Type: Mapping of key-value pairs
            /// Update requires: Updates are not supported.
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-parameter-group.html#cfn-elasticache-parametergroup-properties
            /// </summary>
			public Union<Dictionary<string, string>, IntrinsicFunction> Properties { get; set; }

        }
    
        public string Type { get; } = "AWS::ElastiCache::ParameterGroup";
        
        public ParameterGroupProperties Properties { get; } = new ParameterGroupProperties();
    }
}
