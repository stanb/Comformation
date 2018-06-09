using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.Distribution
{
    /// <summary>
    /// Amazon CloudFront Distribution LambdaFunctionAssociation
    /// The LambdaFunctionAssociation property type specifies a Lambda function association for an Amazon CloudFront
    /// distribution.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-lambdafunctionassociation.html
    /// </summary>
    public class LambdaFunctionAssociation
    {

        /// <summary>
        /// EventType
        /// Specifies the event type that triggers a Lambda function invocation. For valid values and
        /// definitions, see LambdaFunctionAssociation in the Amazon CloudFront API Reference.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EventType")]
        public Union<string, IntrinsicFunction> EventType { get; set; }

        /// <summary>
        /// LambdaFunctionARN
        /// The ARN of the Lambda function. You must specify the ARN of a function version; you can&#39;t specify a
        /// Lambda alias or $LATEST.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LambdaFunctionARN")]
        public Union<string, IntrinsicFunction> LambdaFunctionARN { get; set; }

    }
}
