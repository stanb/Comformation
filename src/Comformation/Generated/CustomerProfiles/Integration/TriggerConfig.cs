using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CustomerProfiles.Integration
{
    /// <summary>
    /// AWS::CustomerProfiles::Integration TriggerConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-integration-triggerconfig.html
    /// </summary>
    public class TriggerConfig
    {

        /// <summary>
        /// TriggerType
        /// Not currently supported by AWS CloudFormation.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TriggerType")]
        public Union<string, IntrinsicFunction> TriggerType { get; set; }

        /// <summary>
        /// TriggerProperties
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: TriggerProperties
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TriggerProperties")]
        public TriggerProperties TriggerProperties { get; set; }

    }
}
