using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.Function
{
    /// <summary>
    /// AWS::CloudFront::Function FunctionMetadata
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-function-functionmetadata.html
    /// </summary>
    public class FunctionMetadata
    {

        /// <summary>
        /// FunctionARN
        /// 		
        /// The Amazon Resource Name (ARN) of the function. The ARN uniquely identifies the 			function.
        /// 	
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FunctionARN")]
        public Union<string, IntrinsicFunction> FunctionARN { get; set; }

    }
}
