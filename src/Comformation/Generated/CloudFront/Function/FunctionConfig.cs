using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.Function
{
    /// <summary>
    /// AWS::CloudFront::Function FunctionConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-function-functionconfig.html
    /// </summary>
    public class FunctionConfig
    {

        /// <summary>
        /// Comment
        /// 		
        /// A comment to describe the function.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Comment")]
        public Union<string, IntrinsicFunction> Comment { get; set; }

        /// <summary>
        /// Runtime
        /// 		
        /// The function’s runtime environment. The only valid value is 			cloudfront-js-1. 0.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Allowed values: cloudfront-js-1. 0
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Runtime")]
        public Union<string, IntrinsicFunction> Runtime { get; set; }

    }
}
