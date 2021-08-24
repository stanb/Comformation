using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSMIncidents.ResponsePlan
{
    /// <summary>
    /// AWS::SSMIncidents::ResponsePlan Action
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmincidents-responseplan-action.html
    /// </summary>
    public class Action
    {

        /// <summary>
        /// SsmAutomation
        /// Details about the Systems Manager automation document that will be used as a runbook during an
        /// incident.
        /// Required: No
        /// Type: SsmAutomation
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SsmAutomation")]
        public SsmAutomation SsmAutomation { get; set; }

    }
}
