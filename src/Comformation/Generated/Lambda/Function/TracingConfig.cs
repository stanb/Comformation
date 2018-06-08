using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Lambda.Function
{
    /// <summary>
    /// AWS Lambda Function TracingConfig
    /// TracingConfig is a property of the AWS::Lambda::Function resource that configures tracing settings for your
    /// AWS Lambda (Lambda) function. For more information about tracing Lambda functions, see Tracing Lambda-Based
    /// Applications with AWS X-Ray in the AWS Lambda Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-function-tracingconfig.html
    /// </summary>
    public class TracingConfig
    {

        /// <summary>
        /// Mode
        /// Specifies how Lambda traces a request. The default mode is PassThrough. For more information, see
        /// TracingConfig in the AWS Lambda Developer Guide.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Mode")]
        public Union<string, IntrinsicFunction> Mode { get; set; }

    }
}
