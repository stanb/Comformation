using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPoolRiskConfigurationAttachment
{
    /// <summary>
    /// AWS::Cognito::UserPoolRiskConfigurationAttachment NotifyEmailType
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolriskconfigurationattachment-notifyemailtype.html
    /// </summary>
    public class NotifyEmailType
    {

        /// <summary>
        /// TextBody
        /// The text body.
        /// Required: No
        /// Type: String
        /// Minimum: 6
        /// Maximum: 20000
        /// Pattern: [\p{L}\p{M}\p{S}\p{N}\p{P}\s*]+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TextBody")]
        public Union<string, IntrinsicFunction> TextBody { get; set; }

        /// <summary>
        /// HtmlBody
        /// The HTML body.
        /// Required: No
        /// Type: String
        /// Minimum: 6
        /// Maximum: 20000
        /// Pattern: [\p{L}\p{M}\p{S}\p{N}\p{P}\s*]+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HtmlBody")]
        public Union<string, IntrinsicFunction> HtmlBody { get; set; }

        /// <summary>
        /// Subject
        /// The subject.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 140
        /// Pattern: [\p{L}\p{M}\p{S}\p{N}\p{P}\s]+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Subject")]
        public Union<string, IntrinsicFunction> Subject { get; set; }

    }
}
