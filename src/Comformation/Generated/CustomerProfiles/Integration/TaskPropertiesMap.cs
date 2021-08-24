using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CustomerProfiles.Integration
{
    /// <summary>
    /// AWS::CustomerProfiles::Integration TaskPropertiesMap
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-integration-taskpropertiesmap.html
    /// </summary>
    public class TaskPropertiesMap
    {

        /// <summary>
        /// OperatorPropertyKey
        /// Not currently supported by AWS CloudFormation.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OperatorPropertyKey")]
        public Union<string, IntrinsicFunction> OperatorPropertyKey { get; set; }

        /// <summary>
        /// Property
        /// Not currently supported by AWS CloudFormation.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Property")]
        public Union<string, IntrinsicFunction> Property { get; set; }

    }
}
