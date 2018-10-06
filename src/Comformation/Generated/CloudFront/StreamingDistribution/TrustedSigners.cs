using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.StreamingDistribution
{
    /// <summary>
    /// Amazon CloudFront StreamingDistribution TrustedSigners
    /// The TrustedSigners property type specifies the AWS accounts, if any, that you want to allow to create signed
    /// URLs for private content for an Amazon CloudFront distribution. For more information, see TrustedSigners in
    /// the Amazon CloudFront API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-streamingdistribution-trustedsigners.html
    /// </summary>
    public class TrustedSigners
    {

        /// <summary>
        /// Enabled
        /// Specifies whether you want to require viewers to use signed URLs to access the files specified by
        /// PathPattern and TargetOriginId.
        /// Required: Yes
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Enabled")]
        public Union<bool, IntrinsicFunction> Enabled { get; set; }

        /// <summary>
        /// AwsAccountNumbers
        /// The trusted signers for this cache behavior.
        /// Required: No
        /// Type: StringList
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AwsAccountNumbers")]
        public List<Union<string, IntrinsicFunction>> AwsAccountNumbers { get; set; }

    }
}
