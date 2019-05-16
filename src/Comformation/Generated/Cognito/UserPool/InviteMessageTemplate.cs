using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPool
{
    /// <summary>
    /// AWS::Cognito::UserPool InviteMessageTemplate
    /// InviteMessageTemplate is a subproperty of the AdminCreateUserConfig property that defines the email and SMS
    /// invitation message structure of an Amazon Cognito User Pool.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-invitemessagetemplate.html
    /// </summary>
    public class InviteMessageTemplate
    {

        /// <summary>
        /// EmailMessage
        /// The message template for email messages.
        /// Required: No
        /// Type: String
        /// Minimum: 6
        /// Maximum: 20000
        /// Pattern: [\p{L}\p{M}\p{S}\p{N}\p{P}\s*]*\{####\}[\p{L}\p{M}\p{S}\p{N}\p{P}\s*]*
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EmailMessage")]
        public Union<string, IntrinsicFunction> EmailMessage { get; set; }

        /// <summary>
        /// SMSMessage
        /// The message template for SMS messages.
        /// Required: No
        /// Type: String
        /// Minimum: 6
        /// Maximum: 140
        /// Pattern: . *\{####\}. *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SMSMessage")]
        public Union<string, IntrinsicFunction> SMSMessage { get; set; }

        /// <summary>
        /// EmailSubject
        /// The subject line for email messages.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 140
        /// Pattern: [\p{L}\p{M}\p{S}\p{N}\p{P}\s]+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EmailSubject")]
        public Union<string, IntrinsicFunction> EmailSubject { get; set; }

    }
}
