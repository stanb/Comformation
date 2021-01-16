using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.KeyGroup
{
    /// <summary>
    /// AWS::CloudFront::KeyGroup
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-keygroup.html
    /// </summary>
    public class KeyGroupResource : ResourceBase
    {
        public class KeyGroupProperties
        {
            /// <summary>
            /// KeyGroupConfig
            /// 		
            /// The key group configuration.
            /// 	
            /// Required: Yes
            /// Type: KeyGroupConfig
            /// Update requires: No interruption
            /// </summary>
            public KeyGroupConfig KeyGroupConfig { get; set; }

        }

        public string Type { get; } = "AWS::CloudFront::KeyGroup";

        public KeyGroupProperties Properties { get; } = new KeyGroupProperties();

    }

    public static class KeyGroupAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> LastModifiedTime = new ResourceAttribute<Union<string, IntrinsicFunction>>("LastModifiedTime");
    }
}
