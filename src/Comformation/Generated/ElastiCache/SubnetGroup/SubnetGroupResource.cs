using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElastiCache.SubnetGroup
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-subnetgroup.html
    /// </summary>
    public class SubnetGroupResource : ResourceBase
    {
        public class SubnetGroupProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-subnetgroup.html#cfn-elasticache-subnetgroup-cachesubnetgroupname
            /// </summary>
			public Union<string, IntrinsicFunction> CacheSubnetGroupName { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-subnetgroup.html#cfn-elasticache-subnetgroup-description
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-subnetgroup.html#cfn-elasticache-subnetgroup-subnetids
            /// </summary>
			public Union<List<string>, IntrinsicFunction> SubnetIds { get; set; }

        }
    
        public string Type { get; } = "AWS::ElastiCache::SubnetGroup";
        
        public SubnetGroupProperties Properties { get; } = new SubnetGroupProperties();
    }
}
