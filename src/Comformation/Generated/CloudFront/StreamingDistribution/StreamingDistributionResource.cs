using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.StreamingDistribution
{
    /// <summary>
    /// AWS::CloudFront::StreamingDistribution
    /// The AWS::CloudFront::StreamingDistribution resource specifies an RMTP distribution for Amazon CloudFront. An
    /// RTMP distribution is similar to a web distribution, but an RTMP distribution streams media files using the
    /// Adobe Real-Time Messaging Protocol (RTMP) instead of serving files using HTTP. For more information, see
    /// CreateStreamingDistribution in the Amazon CloudFront API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-streamingdistribution.html
    /// </summary>
    public class StreamingDistributionResource : ResourceBase
    {
        public class StreamingDistributionProperties
        {
            /// <summary>
            /// StreamingDistributionConfig
            /// Information about the configuration of the RMTP streaming distribution.
            /// Required: Yes
            /// Type: StreamingDistributionConfig
            /// Update requires: No interruption
            /// </summary>
			public StreamingDistributionConfig StreamingDistributionConfig { get; set; }

            /// <summary>
            /// Tags
            /// Key-value tags to assign to this streaming distribution.
            /// Required: Yes
            /// Type: List of Resource Tag
            /// Update requires: No interruption
            /// Duplicates not allowed.
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
