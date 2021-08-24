using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSMContacts.Contact
{
    /// <summary>
    /// AWS::SSMContacts::Contact ContactTargetInfo
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmcontacts-contact-contacttargetinfo.html
    /// </summary>
    public class ContactTargetInfo
    {

        /// <summary>
        /// ContactId
        /// The Amazon Resource Name (ARN) of the contact.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 2048
        /// Pattern: arn:(aws|aws-cn|aws-us-gov):ssm-contacts:[-\w+=\/,. @]*:[0-9]+:([\w+=\/,. @:-]+)*
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ContactId")]
        public Union<string, IntrinsicFunction> ContactId { get; set; }

        /// <summary>
        /// IsEssential
        /// A Boolean value determining if the contact&#39;s acknowledgement stops the progress of stages in the
        /// plan.
        /// Required: Yes
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IsEssential")]
        public Union<bool, IntrinsicFunction> IsEssential { get; set; }

    }
}
