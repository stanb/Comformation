using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.Distribution
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-distribution.html
    /// </summary>
    public class DistributionResource : ResourceBase
    {
        public class DistributionProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-distribution.html#cfn-cloudfront-distribution-distributionconfig
            /// </summary>
			public Union<DistributionConfig, IntrinsicFunction> DistributionConfig { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-distribution.html#cfn-cloudfront-distribution-tags
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
