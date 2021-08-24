using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPoolClient
{
    /// <summary>
    /// AWS::Cognito::UserPoolClient AnalyticsConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolclient-analyticsconfiguration.html
    /// </summary>
    public class AnalyticsConfiguration
    {

        /// <summary>
        /// ApplicationArn
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ApplicationArn")]
        public Union<string, IntrinsicFunction> ApplicationArn { get; set; }

        /// <summary>
        /// UserDataShared
        /// If UserDataShared is true, Amazon Cognito will include user data in the events it publishes to
        /// Amazon Pinpoint analytics.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UserDataShared")]
        public Union<bool, IntrinsicFunction> UserDataShared { get; set; }

        /// <summary>
        /// ExternalId
        /// The external ID.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ExternalId")]
        public Union<string, IntrinsicFunction> ExternalId { get; set; }

        /// <summary>
        /// ApplicationId
        /// The application ID for an Amazon Pinpoint application.
        /// Required: No
        /// Type: String
        /// Pattern: ^[0-9a-fA-F]+$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ApplicationId")]
        public Union<string, IntrinsicFunction> ApplicationId { get; set; }

        /// <summary>
        /// RoleArn
        /// The ARN of an IAM role that authorizes Amazon Cognito to publish events to Amazon Pinpoint
        /// analytics.
        /// Required: No
        /// Type: String
        /// Minimum: 20
        /// Maximum: 2048
        /// Pattern: arn:[\w+=/,. @-]+:[\w+=/,. @-]+:([\w+=/,. @-]*)?:[0-9]+:[\w+=/,. @-]+(:[\w+=/,.
        /// @-]+)?(:[\w+=/,. @-]+)?
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

    }
}
