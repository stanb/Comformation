using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.TaskDefinition
{
    /// <summary>
    /// AWS::ECS::TaskDefinition InferenceAccelerator
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-inferenceaccelerator.html
    /// </summary>
    public class InferenceAccelerator
    {

        /// <summary>
        /// DeviceName
        /// The Elastic Inference accelerator device name. The deviceName must also be referenced in a container
        /// definition as a ResourceRequirement.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("DeviceName")]
        public Union<string, IntrinsicFunction> DeviceName { get; set; }

        /// <summary>
        /// DeviceType
        /// 		
        /// The Elastic Inference accelerator type to use.
        /// 	
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("DeviceType")]
        public Union<string, IntrinsicFunction> DeviceType { get; set; }

    }
}
