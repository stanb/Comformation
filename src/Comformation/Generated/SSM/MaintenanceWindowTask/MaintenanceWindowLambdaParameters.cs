using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSM.MaintenanceWindowTask
{
    /// <summary>
    /// AWS::SSM::MaintenanceWindowTask MaintenanceWindowLambdaParameters
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-maintenancewindowtask-maintenancewindowlambdaparameters.html
    /// </summary>
    public class MaintenanceWindowLambdaParameters
    {

        /// <summary>
        /// ClientContext
        /// Client-specific information to pass to the AWS Lambda function that you&#39;re invoking. You can then
        /// use the context variable to process the client information in your AWS Lambda function.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 8000
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ClientContext")]
        public Union<string, IntrinsicFunction> ClientContext { get; set; }

        /// <summary>
        /// Qualifier
        /// An AWS Lambda function version or alias name. If you specify a function version, the action uses the
        /// qualified function Amazon Resource Name (ARN) to invoke a specific Lambda function. If you specify
        /// an alias name, the action uses the alias ARN to invoke the Lambda function version that the alias
        /// points to.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 128
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Qualifier")]
        public Union<string, IntrinsicFunction> Qualifier { get; set; }

        /// <summary>
        /// Payload
        /// JSON to provide to your AWS Lambda function as input.
        /// Important Although Type is listed as &quot;String&quot; for this property, the payload content must be
        /// formatted as a Base64-encoded binary data object.
        /// Length Constraint: 4096
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Payload")]
        public Union<string, IntrinsicFunction> Payload { get; set; }

    }
}
