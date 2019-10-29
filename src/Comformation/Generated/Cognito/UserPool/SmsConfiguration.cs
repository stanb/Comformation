using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPool
{
    /// <summary>
    /// AWS::Cognito::UserPool SmsConfiguration
    /// SmsConfiguration is a property of the AWS::Cognito::UserPool resource that defines the SMS configuration of an
    /// Amazon Cognito user pool.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-smsconfiguration.html
    /// </summary>
    public class SmsConfiguration
    {

        /// <summary>
        /// ExternalId
        /// The external ID used in IAM role trust relationships.
        /// For more information about using external IDs, see How to Use an External ID When Granting Access to
        /// Your AWS Resources to a Third Party in the AWS Identity and Access Management User Guide.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ExternalId")]
        public Union<string, IntrinsicFunction> ExternalId { get; set; }

        /// <summary>
        /// SnsCallerArn
        /// The Amazon Resource Name (ARN) of the Amazon Simple Notification Service (SNS) caller. This is the
        /// ARN of the IAM role in your AWS account which Cognito will use to send SMS messages.
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
