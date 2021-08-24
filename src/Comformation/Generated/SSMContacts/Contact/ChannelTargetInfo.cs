using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSMContacts.Contact
{
    /// <summary>
    /// AWS::SSMContacts::Contact ChannelTargetInfo
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmcontacts-contact-channeltargetinfo.html
    /// </summary>
    public class ChannelTargetInfo
    {

        /// <summary>
        /// ChannelId
        /// The Amazon Resource Name (ARN) of the contact channel.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 2048
        /// Pattern: arn:(aws|aws-cn|aws-us-gov):ssm-contacts:[-\w+=\/,. @]*:[0-9]+:([\w+=\/,. @:-]+)*
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ChannelId")]
        public Union<string, IntrinsicFunction> ChannelId { get; set; }

        /// <summary>
        /// RetryIntervalInMinutes
        /// The number of minutes to wait to retry sending engagement in the case the engagement initially
        /// fails.
        /// Required: Yes
        /// Type: Integer
        /// Minimum: 0
        /// Maximum: 60
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RetryIntervalInMinutes")]
        public Union<int, IntrinsicFunction> RetryIntervalInMinutes { get; set; }

    }
}
