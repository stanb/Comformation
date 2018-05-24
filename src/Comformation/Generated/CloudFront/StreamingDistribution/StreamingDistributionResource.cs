using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.StreamingDistribution
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-streamingdistribution.html
    /// </summary>
    public class StreamingDistributionResource : ResourceBase
    {
        public class StreamingDistributionProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-streamingdistribution.html#cfn-cloudfront-streamingdistribution-streamingdistributionconfig
            /// </summary>
			public Union<StreamingDistributionConfig, IntrinsicFunction> StreamingDistributionConfig { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-streamingdistribution.html#cfn-cloudfront-streamingdistribution-tags
            /// </summary>
			public Union<List<Tag>, IntrinsicFunction> Tags { get; set; }

        }
    
        public string Type { get; } = "AWS::CloudFront::StreamingDistribution";
        
        public StreamingDistributionProperties Properties { get; } = new StreamingDistributionProperties();
    }

	public static class StreamingDistributionAttributes
	{
        public static readonly ResourceAttribute<string> DomainName = new ResourceAttribute<string>("DomainName");
	}
}
