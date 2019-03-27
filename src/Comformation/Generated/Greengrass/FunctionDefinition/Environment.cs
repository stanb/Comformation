using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Greengrass.FunctionDefinition
{
    /// <summary>
    /// AWS IoT Greengrass FunctionDefinition Environment
    /// The environment configuration for a Lambda function on the AWS IoT Greengrass core.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinition-environment.html
    /// </summary>
    public class Environment
    {

        /// <summary>
        /// Variables
        /// Environment variables for the Lambda function.
        /// Required: No
        /// Type: Json
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Variables")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Variables { get; set; }

        /// <summary>
        /// Execution
        /// Settings for the Lambda execution environment in AWS IoT Greengrass.
        /// Required: No
        /// Type: Execution
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Execution")]
        public Execution Execution { get; set; }

        /// <summary>
        /// ResourceAccessPolicies
        /// A list of the resources in the group 				 that the function can access, with the corresponding
        /// read-only or read-write permissions. The maximum is 10 resources.
        /// 				
        /// Note This property applies only for Lambda functions that run in a Greengrass container.
        /// Required: No
        /// Type: List of ResourceAccessPolicy
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ResourceAccessPolicies")]
        public List<ResourceAccessPolicy> ResourceAccessPolicies { get; set; }

        /// <summary>
        /// AccessSysfs
        /// Indicates whether the function is allowed to access the /sys directory on the core device, which
        /// allows the 				 read device information from /sys.
        /// 				 				
        /// Note This property applies only to Lambda functions that run in a Greengrass container.
        /// Required: No
        /// Type: Boolean
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("AccessSysfs")]
        public Union<bool, IntrinsicFunction> AccessSysfs { get; set; }

    }
}
