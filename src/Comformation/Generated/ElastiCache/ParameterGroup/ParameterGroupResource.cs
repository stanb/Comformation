using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElastiCache.ParameterGroup
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-parameter-group.html
    /// </summary>
    public class ParameterGroupResource : ResourceBase
    {
        public class ParameterGroupProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-parameter-group.html#cfn-elasticache-parametergroup-cacheparametergroupfamily
            /// </summary>
			public Union<string, IntrinsicFunction> CacheParameterGroupFamily { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-parameter-group.html#cfn-elasticache-parametergroup-description
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-parameter-group.html#cfn-elasticache-parametergroup-properties
            /// </summary>
			public Union<Dictionary<string, string>, IntrinsicFunction> Properties { get; set; }

        }
    
        public string Type { get; } = "AWS::ElastiCache::ParameterGroup";
        
        public ParameterGroupProperties Properties { get; } = new ParameterGroupProperties();
    }
}
