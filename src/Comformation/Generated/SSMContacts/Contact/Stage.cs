using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSMContacts.Contact
{
    /// <summary>
    /// AWS::SSMContacts::Contact Stage
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmcontacts-contact-stage.html
    /// </summary>
    public class Stage
    {

        /// <summary>
        /// DurationInMinutes
        /// The time to wait until beginning the next stage. The duration can only be set to 0 if a target is
        /// specified.
        /// Required: Yes
        /// Type: Integer
        /// Minimum: 0
        /// Maximum: 30
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DurationInMinutes")]
        public Union<int, IntrinsicFunction> DurationInMinutes { get; set; }

        /// <summary>
        /// Targets
        /// The contacts or contact methods that the escalation plan or engagement plan is engaging.
        /// Required: No
        /// Type: List of Targets
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Targets")]
        public List<Targets> Targets { get; set; }

    }
}
