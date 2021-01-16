using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPoolRiskConfigurationAttachment
{
    /// <summary>
    /// AWS::Cognito::UserPoolRiskConfigurationAttachment NotifyConfigurationType
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolriskconfigurationattachment-notifyconfigurationtype.html
    /// </summary>
    public class NotifyConfigurationType
    {

        /// <summary>
        /// BlockEmail
        /// Email template used when a detected risk event is blocked.
        /// Required: No
        /// Type: NotifyEmailType
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BlockEmail")]
        public NotifyEmailType BlockEmail { get; set; }

        /// <summary>
        /// ReplyTo
        /// The destination to which the receiver of an email should reply to.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ReplyTo")]
        public Union<string, IntrinsicFunction> ReplyTo { get; set; }

        /// <summary>
        /// SourceArn
        /// The Amazon Resource Name (ARN) of the identity that is associated with the sending authorization
        /// policy. It permits Amazon Cognito to send for the email address specified in the From parameter.
        /// Required: Yes
        /// Type: String
        /// Minimum: 20
        /// Maximum: 2048
        /// Pattern: arn:[\w+=/,. @-]+:[\w+=/,. @-]+:([\w+=/,. @-]*)?:[0-9]+:[\w+=/,. @-]+(:[\w+=/,.
        /// @-]+)?(:[\w+=/,. @-]+)?
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SourceArn")]
        public Union<string, IntrinsicFunction> SourceArn { get; set; }

        /// <summary>
        /// NoActionEmail
        /// The email template used when a detected risk event is allowed.
        /// Required: No
        /// Type: NotifyEmailType
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NoActionEmail")]
        public NotifyEmailType NoActionEmail { get; set; }

        /// <summary>
        /// From
        /// The email address that is sending the email. It must be either individually verified with Amazon
        /// SES, or from a domain that has been verified with Amazon SES.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("From")]
        public Union<string, IntrinsicFunction> From { get; set; }

        /// <summary>
        /// MfaEmail
        /// The MFA email template used when MFA is challenged as part of a detected risk.
        /// Required: No
        /// Type: NotifyEmailType
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MfaEmail")]
        public NotifyEmailType MfaEmail { get; set; }

    }
}
