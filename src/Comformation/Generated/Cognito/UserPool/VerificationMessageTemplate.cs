using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPool
{
    /// <summary>
    /// AWS::Cognito::UserPool VerificationMessageTemplate
    /// VerificationMessageTemplate is a property of the AWS::Cognito::UserPool resource that defines the template for
    /// verification messages.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-verificationmessagetemplate.html
    /// </summary>
    public class VerificationMessageTemplate
    {

        /// <summary>
        /// EmailMessageByLink
        /// The email message template for sending a confirmation link to the user.
        /// Required: No
        /// Type: String
        /// Minimum: 6
        /// Maximum: 20000
        /// Pattern:
        /// [\p{L}\p{M}\p{S}\p{N}\p{P}\s*]*\{##[\p{L}\p{M}\p{S}\p{N}\p{P}\s*]*##\}[\p{L}\p{M}\p{S}\p{N}\p{P}\s*]*
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EmailMessageByLink")]
        public Union<string, IntrinsicFunction> EmailMessageByLink { get; set; }

        /// <summary>
        /// EmailMessage
        /// The email message template.
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
        /// SmsMessage
        /// The SMS message template.
        /// Required: No
        /// Type: String
        /// Minimum: 6
        /// Maximum: 140
        /// Pattern: . *\{####\}. *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SmsMessage")]
        public Union<string, IntrinsicFunction> SmsMessage { get; set; }

        /// <summary>
        /// EmailSubject
        /// The subject line for the email message template.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 140
        /// Pattern: [\p{L}\p{M}\p{S}\p{N}\p{P}\s]+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EmailSubject")]
        public Union<string, IntrinsicFunction> EmailSubject { get; set; }

        /// <summary>
        /// DefaultEmailOption
        /// The default email option.
        /// Required: No
        /// Type: String
        /// Allowed Values: CONFIRM_WITH_CODE | CONFIRM_WITH_LINK
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DefaultEmailOption")]
        public Union<string, IntrinsicFunction> DefaultEmailOption { get; set; }

        /// <summary>
        /// EmailSubjectByLink
        /// The subject line for the email message template for sending a confirmation link to the user.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 140
        /// Pattern: [\p{L}\p{M}\p{S}\p{N}\p{P}\s]+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EmailSubjectByLink")]
        public Union<string, IntrinsicFunction> EmailSubjectByLink { get; set; }

    }
}
