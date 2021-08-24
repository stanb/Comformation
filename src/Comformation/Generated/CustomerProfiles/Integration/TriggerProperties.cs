using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CustomerProfiles.Integration
{
    /// <summary>
    /// AWS::CustomerProfiles::Integration TriggerProperties
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-integration-triggerproperties.html
    /// </summary>
    public class TriggerProperties
    {

        /// <summary>
        /// Scheduled
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: ScheduledTriggerProperties
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Scheduled")]
        public ScheduledTriggerProperties Scheduled { get; set; }

    }
}
