using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElastiCache.SecurityGroup
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-security-group.html
    /// </summary>
    public class SecurityGroupResource : ResourceBase
    {
        public class SecurityGroupProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-security-group.html#cfn-elasticache-securitygroup-description
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

        }
    
        public string Type { get; } = "AWS::ElastiCache::SecurityGroup";
        
        public SecurityGroupProperties Properties { get; } = new SecurityGroupProperties();
    }
}
