using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Greengrass.FunctionDefinitionVersion
{
    /// <summary>
    /// AWS::Greengrass::FunctionDefinitionVersion ResourceAccessPolicy
    /// A list of the 		resources in the group 				 that the function can access, with the corresponding read-only or
    /// read-write permissions. The maximum is 10 resources.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinitionversion-resourceaccesspolicy.html
    /// </summary>
    public class ResourceAccessPolicy
    {

        /// <summary>
        /// ResourceId
        /// The ID of the resource. This ID is assigned to the resource when you create the resource definition.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ResourceId")]
        public Union<string, IntrinsicFunction> ResourceId { get; set; }

        /// <summary>
        /// Permission
        /// The read-only or read-write access that the Lambda function has to the resource. 				 Valid values
        /// are ro or rw.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Permission")]
        public Union<string, IntrinsicFunction> Permission { get; set; }

    }
}
