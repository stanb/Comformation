using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPool
{
    /// <summary>
    /// Amazon Cognito UserPool EmailConfiguration
    /// EmailConfiguration is a property of the AWS::Cognito::UserPool resource that defines the email configuration
    /// of an Amazon Cognito User Pool.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-emailconfiguration.html
    /// </summary>
    public class EmailConfiguration
    {

        /// <summary>
        /// ReplyToEmailAddress
        /// The REPLY-TO email address.
        /// Type: String
        /// Required: No
        /// </summary>
        [JsonProperty("ReplyToEmailAddress")]
        public Union<string, IntrinsicFunction> ReplyToEmailAddress { get; set; }

        /// <summary>
        /// SourceArn
        /// The Amazon Resource Name (ARN) of the email source.
        /// Type: String
        /// Required: No
        /// </summary>
        [JsonProperty("SourceArn")]
        public Union<string, IntrinsicFunction> SourceArn { get; set; }

    }
}
