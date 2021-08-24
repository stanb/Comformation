using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.Distribution
{
    /// <summary>
    /// AWS::CloudFront::Distribution FunctionAssociation
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-functionassociation.html
    /// </summary>
    public class FunctionAssociation
    {

        /// <summary>
        /// EventType
        /// 		
        /// The event type of the function, either viewer-request or 			viewer-response. You cannot use
        /// origin-facing event types 			(origin-request and origin-response) with a CloudFront 			function.
        /// 	
        /// Required: No
        /// Type: String
        /// Allowed values: origin-request | origin-response | viewer-request | viewer-response
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EventType")]
        public Union<string, IntrinsicFunction> EventType { get; set; }

        /// <summary>
        /// FunctionARN
        /// 		
        /// The Amazon Resource Name (ARN) of the function.
        /// 	
        /// Required: No
        /// Type: String
        /// Maximum: 108
        /// Pattern: arn:aws:cloudfront::[0-9]{12}:function\/[a-zA-Z0-9-_]{1,64}$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FunctionARN")]
        public Union<string, IntrinsicFunction> FunctionARN { get; set; }

    }
}
