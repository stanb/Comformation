using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.Distribution
{
    /// <summary>
    /// AWS::CloudFront::Distribution
    /// Creates an Amazon CloudFront web distribution. For general information about CloudFront distributions, see the
    /// Introduction to Amazon CloudFront in the Amazon CloudFront Developer Guide. For specific information about
    /// creating CloudFront web distributions, see CreateDistribution in the Amazon CloudFront API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-distribution.html
    /// </summary>
    public class DistributionResource : ResourceBase
    {
        public class DistributionProperties
        {
            /// <summary>
            /// DistributionConfig
            /// The distribution&#39;s configuration information.
            /// Required: Yes
            /// Type: DistributionConfig type
            /// Update requires: No interruption
            /// </summary>
			public Union<DistributionConfig, IntrinsicFunction> DistributionConfig { get; set; }

            /// <summary>
            /// Tags
            /// An arbitrary set of tags (key–value pairs) to associate with a CloudFront distribution.
            /// Required: No
            /// Type: List of
            /// Update requires: No interruption
            /// Duplicates not allowed.
            /// </summary>
			public Union<List<Tag>, IntrinsicFunction> Tags { get; set; }

        }
    
        public string Type { get; } = "AWS::CloudFront::Distribution";
        
        public DistributionProperties Properties { get; } = new DistributionProperties();
    }

	public static class DistributionAttributes
	{
        public static readonly ResourceAttribute<string> DomainName = new ResourceAttribute<string>("DomainName");
	}
}
