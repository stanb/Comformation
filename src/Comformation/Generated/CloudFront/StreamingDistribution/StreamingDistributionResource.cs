using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.StreamingDistribution
{
    /// <summary>
    /// AWS::CloudFront::StreamingDistribution
    /// A streaming distribution tells CloudFront where you want RTMP content to be delivered from, and the details
    /// about how to 			track and manage content delivery.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-streamingdistribution.html
    /// </summary>
    public class StreamingDistributionResource : ResourceBase
    {
        public class StreamingDistributionProperties
        {
            /// <summary>
            /// StreamingDistributionConfig
            /// 		
            /// The current configuration information for the RTMP distribution.
            /// 	
            /// Required: Yes
            /// Type: StreamingDistributionConfig
            /// Update requires: No interruption
            /// </summary>
			public StreamingDistributionConfig StreamingDistributionConfig { get; set; }

            /// <summary>
            /// Tags
            /// 		
            /// A complex type that contains zero or more Tag elements.
            /// 	
            /// Required: Yes
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::CloudFront::StreamingDistribution";

        public StreamingDistributionProperties Properties { get; } = new StreamingDistributionProperties();

    }

	public static class StreamingDistributionAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> DomainName = new ResourceAttribute<Union<string, IntrinsicFunction>>("DomainName");
	}
}
