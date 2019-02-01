using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPool
{
    /// <summary>
    /// Amazon Cognito UserPool InviteMessageTemplate
    /// InviteMessageTemplate is a subproperty of the Amazon Cognito UserPool AdminCreateUserConfig property that
    /// defines the email and SMS invitation message structure of an Amazon Cognito User Pool.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-admincreateuserconfig-invitemessagetemplate.html
    /// </summary>
    public class InviteMessageTemplate
    {

        /// <summary>
        /// EmailMessage
        /// The message template for email messages.
        /// Type: String
        /// Required: No
        /// </summary>
        [JsonProperty("EmailMessage")]
        public Union<string, IntrinsicFunction> EmailMessage { get; set; }

        /// <summary>
        /// SMSMessage
        /// The message template for SMS messages.
        /// Type: String
        /// Required: No
        /// </summary>
        [JsonProperty("SMSMessage")]
        public Union<string, IntrinsicFunction> SMSMessage { get; set; }

        /// <summary>
        /// EmailSubject
        /// The subject line for email messages.
        /// Type: String
        /// Required: No
        /// </summary>
        [JsonProperty("EmailSubject")]
        public Union<string, IntrinsicFunction> EmailSubject { get; set; }

    }
}
