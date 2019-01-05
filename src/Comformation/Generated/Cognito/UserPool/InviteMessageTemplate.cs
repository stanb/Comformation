using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPool
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-invitemessagetemplate.html
    /// </summary>
    public class InviteMessageTemplate
    {

        /// <summary>
        /// EmailMessage
        /// </summary>
        [JsonProperty("EmailMessage")]
        public Union<string, IntrinsicFunction> EmailMessage { get; set; }

        /// <summary>
        /// SMSMessage
        /// </summary>
        [JsonProperty("SMSMessage")]
        public Union<string, IntrinsicFunction> SMSMessage { get; set; }

        /// <summary>
        /// EmailSubject
        /// </summary>
        [JsonProperty("EmailSubject")]
        public Union<string, IntrinsicFunction> EmailSubject { get; set; }

    }
}
