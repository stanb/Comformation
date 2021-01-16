using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DLM.LifecyclePolicy
{
    /// <summary>
    /// AWS::DLM::LifecyclePolicy EventSource
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-eventsource.html
    /// </summary>
    public class EventSource
    {

        /// <summary>
        /// Type
        /// 		
        /// The source of the event. Currently only managed AWS CloudWatch Events rules are supported.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Allowed values: MANAGED_CWE
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// Parameters
        /// 		
        /// Information about the event.
        /// 	
        /// Required: No
        /// Type: EventParameters
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Parameters")]
        public EventParameters Parameters { get; set; }

    }
}
