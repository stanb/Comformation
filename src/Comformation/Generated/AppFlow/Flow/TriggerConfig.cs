using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppFlow.Flow
{
    /// <summary>
    /// AWS::AppFlow::Flow TriggerConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-triggerconfig.html
    /// </summary>
    public class TriggerConfig
    {

        /// <summary>
        /// TriggerType
        /// Specifies the type of flow trigger. This can be OnDemand, Scheduled, or Event.
        /// Required: Yes
        /// Type: String
        /// Allowed values: Event | OnDemand | Scheduled
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TriggerType")]
        public Union<string, IntrinsicFunction> TriggerType { get; set; }

        /// <summary>
        /// TriggerProperties
        /// Specifies the configuration details of a schedule-triggered flow as defined by the user. Currently,
        /// these settings only apply to the Scheduled trigger type.
        /// Required: No
        /// Type: ScheduledTriggerProperties
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TriggerProperties")]
        public ScheduledTriggerProperties TriggerProperties { get; set; }

    }
}
