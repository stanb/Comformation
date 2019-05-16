using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.Distribution
{
    /// <summary>
    /// AWS::CloudFront::Distribution
    /// The distribution&#39;s information.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-distribution.html
    /// </summary>
    public class DistributionResource : ResourceBase
    {
        public class DistributionProperties
        {
            /// <summary>
            /// DistributionConfig
            /// 		
            /// The current configuration information for the distribution. Send a GET 			request to the /CloudFront
            /// API version/distribution ID/config 			resource.
            /// 	
            /// Required: Yes
            /// Type: DistributionConfig
            /// Update requires: No interruption
            /// </summary>
			public DistributionConfig DistributionConfig { get; set; }

            /// <summary>
            /// Tags
            /// 		
            /// A complex type that contains zero or more Tag elements.
            /// 	
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::CloudFront::Distribution";

        public DistributionProperties Properties { get; } = new DistributionProperties();

    }

	public static class DistributionAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> DomainName = new ResourceAttribute<Union<string, IntrinsicFunction>>("DomainName");
	}
}
