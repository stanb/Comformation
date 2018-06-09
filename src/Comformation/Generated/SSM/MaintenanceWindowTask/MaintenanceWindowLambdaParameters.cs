using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSM.MaintenanceWindowTask
{
    /// <summary>
    /// AWS Systems Manager MaintenanceWindowTask MaintenanceWindowLambdaParameters
    /// The MaintenanceWindowLambdaParameters property type specifies the parameters for a LAMBDA task type for a
    /// Maintenance Window task in AWS Systems Manager.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-maintenancewindowtask-maintenancewindowlambdaparameters.html
    /// </summary>
    public class MaintenanceWindowLambdaParameters
    {

        /// <summary>
        /// ClientContext
        /// Client-specific information to pass to the Lambda function that you&#39;re invoking. You can then use
        /// the context variable to process the client information in your Lambda function.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ClientContext")]
        public Union<string, IntrinsicFunction> ClientContext { get; set; }

        /// <summary>
        /// Qualifier
        /// A Lambda function version or alias name. If you specify a function version, the action uses the
        /// qualified function Amazon Resource Name (ARN) to invoke a specific Lambda function. If you specify
        /// an alias name, the action uses the alias ARN to invoke the Lambda function version that the alias
        /// points to.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Qualifier")]
        public Union<string, IntrinsicFunction> Qualifier { get; set; }

        /// <summary>
        /// Payload
        /// JSON to provide to your Lambda function as input.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Payload")]
        public Union<string, IntrinsicFunction> Payload { get; set; }

    }
}
