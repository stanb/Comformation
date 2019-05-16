using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.Distribution
{
    /// <summary>
    /// AWS::CloudFront::Distribution LambdaFunctionAssociation
    /// A complex type that contains a Lambda function association.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-lambdafunctionassociation.html
    /// </summary>
    public class LambdaFunctionAssociation
    {

        /// <summary>
        /// EventType
        /// 		
        /// Specifies the event type that triggers a Lambda function invocation. You can specify the following
        /// values:
        /// 		
        /// 			 			 			 			 		 viewer-request: The function executes when CloudFront receives a request from a
        /// viewer 				and before it checks to see whether the requested object is in the edge cache.
        /// origin-request: The function executes only when CloudFront forwards a request to your origin.
        /// 				When the requested object is in the edge cache, the function doesn&#39;t execute. origin-response:
        /// The function executes after CloudFront receives a response from the origin and 				before it caches
        /// the object in the response. When the requested object is in the edge cache, the function doesn&#39;t
        /// execute. 			 viewer-response: The function executes before CloudFront returns the requested object
        /// to the viewer. 				The function executes regardless of whether the object was already in the edge
        /// cache. 				 If the origin returns an HTTP status code other than HTTP 200 (OK), the function doesn&#39;t
        /// execute. 			
        /// 	
        /// Required: No
        /// Type: String
        /// Allowed Values: origin-request | origin-response | viewer-request | viewer-response
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EventType")]
        public Union<string, IntrinsicFunction> EventType { get; set; }

        /// <summary>
        /// LambdaFunctionARN
        /// 		
        /// The ARN of the Lambda function. You must specify the ARN of a function version; you can&#39;t specify a
        /// Lambda alias 			or $LATEST.
        /// 	
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LambdaFunctionARN")]
        public Union<string, IntrinsicFunction> LambdaFunctionARN { get; set; }

    }
}
