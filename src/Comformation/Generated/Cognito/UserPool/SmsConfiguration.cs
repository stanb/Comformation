using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPool
{
    /// <summary>
    /// AWS::Cognito::UserPool SmsConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-smsconfiguration.html
    /// </summary>
    public class SmsConfiguration
    {

        /// <summary>
        /// ExternalId
        /// The external ID is a value. We recommend you use ExternalIdto add security to your IAM role, which
        /// is used to call Amazon SNS to send SMS messages for your user pool. If you provide an ExternalId,
        /// the Cognito User Pool uses it when attempting to assume your IAM role. You can also set your roles
        /// trust policy to require the ExternalID. If you use the Cognito Management Console to create a role
        /// for SMS MFA, Cognito creates a role with the required permissions and a trust policy that uses
        /// ExternalId.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ExternalId")]
        public Union<string, IntrinsicFunction> ExternalId { get; set; }

        /// <summary>
        /// SnsCallerArn
        /// The Amazon Resource Name (ARN) of the Amazon Simple Notification Service (SNS) caller. This is the
        /// ARN of the IAM role in your AWS account which Cognito will use to send SMS messages. SMS messages
        /// are subject to a spending limit.
        /// Required: No
        /// Type: String
        /// Minimum: 20
        /// Maximum: 2048
        /// Pattern: arn:[\w+=/,. @-]+:[\w+=/,. @-]+:([\w+=/,. @-]*)?:[0-9]+:[\w+=/,. @-]+(:[\w+=/,.
        /// @-]+)?(:[\w+=/,. @-]+)?
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SnsCallerArn")]
        public Union<string, IntrinsicFunction> SnsCallerArn { get; set; }

    }
}
