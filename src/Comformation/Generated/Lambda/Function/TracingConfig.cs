using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Lambda.Function
{
    /// <summary>
    /// AWS::Lambda::Function TracingConfig
    /// The function&#39;s AWS X-Ray tracing configuration.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-function-tracingconfig.html
    /// </summary>
    public class TracingConfig
    {

        /// <summary>
        /// Mode
        /// The tracing mode.
        /// Required: No
        /// Type: String
        /// Allowed Values: Active | PassThrough
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Mode")]
        public Union<string, IntrinsicFunction> Mode { get; set; }

    }
}
