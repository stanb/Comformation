using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.GreengrassV2.ComponentVersion
{
    /// <summary>
    /// AWS::GreengrassV2::ComponentVersion LambdaLinuxProcessParams
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-componentversion-lambdalinuxprocessparams.html
    /// </summary>
    public class LambdaLinuxProcessParams
    {

        /// <summary>
        /// IsolationMode
        /// The isolation mode for the process that contains the Lambda function. The process can run in an
        /// isolated runtime environment inside the AWS IoT Greengrass container, or as a regular process
        /// outside any container.
        /// Default: GreengrassContainer
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("IsolationMode")]
        public Union<string, IntrinsicFunction> IsolationMode { get; set; }

        /// <summary>
        /// ContainerParams
        /// The parameters for the container in which the Lambda function runs.
        /// Required: No
        /// Type: LambdaContainerParams
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ContainerParams")]
        public LambdaContainerParams ContainerParams { get; set; }

    }
}
