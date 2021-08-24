using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSMContacts.Contact
{
    /// <summary>
    /// AWS::SSMContacts::Contact Targets
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmcontacts-contact-targets.html
    /// </summary>
    public class Targets
    {

        /// <summary>
        /// ContactTargetInfo
        /// The contact that Incident Manager is engaging during an incident.
        /// Required: No
        /// Type: ContactTargetInfo
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ContactTargetInfo")]
        public ContactTargetInfo ContactTargetInfo { get; set; }

        /// <summary>
        /// ChannelTargetInfo
        /// Information about the contact channel Incident Manager is engaging.
        /// Required: No
        /// Type: ChannelTargetInfo
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ChannelTargetInfo")]
        public ChannelTargetInfo ChannelTargetInfo { get; set; }

    }
}
