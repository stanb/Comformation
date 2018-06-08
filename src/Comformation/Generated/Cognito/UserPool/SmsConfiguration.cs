using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPool
{
    /// <summary>
    /// Amazon Cognito UserPool SmsConfiguration
    /// SmsConfiguration is a property of the AWS::Cognito::UserPool resource that defines the SMS configuration of an
    /// Amazon Cognito User Pool.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-smsconfiguration.html
    /// </summary>
    public class SmsConfiguration
    {

        /// <summary>
        /// ExternalId
        /// The external ID used in IAM role trust relationships.
        /// For more information about using external IDs, see How to Use an External ID When Granting Access to
        /// Your AWS Resources to a Third Party in the AWS Identity and Access Management User Guide.
        /// Type: String
        /// Required: No
        /// </summary>
        [JsonProperty("ExternalId")]
        public Union<string, IntrinsicFunction> ExternalId { get; set; }

        /// <summary>
        /// SnsCallerArn
        /// The Amazon Resource Name (ARN) of the Amazon Simple Notification Service (SNS) caller.
        /// Type: String
        /// Required: Yes
        /// </summary>
        [JsonProperty("SnsCallerArn")]
        public Union<string, IntrinsicFunction> SnsCallerArn { get; set; }

    }
}
