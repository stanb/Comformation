using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.PinpointEmail.Identity
{
    /// <summary>
    /// AWS::PinpointEmail::Identity MailFromAttributes
    /// A list of attributes that are associated with a MAIL FROM domain.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpointemail-identity-mailfromattributes.html
    /// </summary>
    public class MailFromAttributes
    {

        /// <summary>
        /// MailFromDomain
        /// The name of a domain that an email identity uses as a custom MAIL FROM domain.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MailFromDomain")]
        public Union<string, IntrinsicFunction> MailFromDomain { get; set; }

        /// <summary>
        /// BehaviorOnMxFailure
        /// The action that Amazon Pinpoint to takes if it can&#39;t read the required MX record for a custom MAIL
        /// FROM domain. When you set this value to UseDefaultValue, Amazon Pinpoint uses amazonses. com as the
        /// MAIL FROM domain. When you set this value to RejectMessage, Amazon Pinpoint returns a
        /// MailFromDomainNotVerified error, and doesn&#39;t attempt to deliver the email.
        /// These behaviors are taken when the custom MAIL FROM domain configuration is in the Pending, Failed,
        /// and TemporaryFailure states.
        /// Required: No
        /// Type: String
        /// Allowed Values: REJECT_MESSAGE | USE_DEFAULT_VALUE
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BehaviorOnMxFailure")]
        public Union<string, IntrinsicFunction> BehaviorOnMxFailure { get; set; }

    }
}
