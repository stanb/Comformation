using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.IdentityPool
{
    /// <summary>
    /// Amazon Cognito IdentityPool CognitoStreams
    /// CognitoStreams is a property of the AWS::Cognito::IdentityPool resource that defines configuration options for
    /// Amazon Cognito streams.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-identitypool-cognitostreams.html
    /// </summary>
    public class CognitoStreams
    {

        /// <summary>
        /// StreamingStatus
        /// Status of the Cognito streams. Valid values are: ENABLED or DISABLED.
        /// Type: String
        /// Required: No
        /// </summary>
        [JsonProperty("StreamingStatus")]
        public Union<string, IntrinsicFunction> StreamingStatus { get; set; }

        /// <summary>
        /// StreamName
        /// The name of the Amazon Cognito stream to receive updates. This stream must be in the developer&#39;s
        /// account and in the same region as the identity pool.
        /// Type: String
        /// Required: No
        /// </summary>
        [JsonProperty("StreamName")]
        public Union<string, IntrinsicFunction> StreamName { get; set; }

        /// <summary>
        /// RoleArn
        /// The Amazon Resource Name (ARN) of the role Amazon Cognito can assume to publish to the stream. This
        /// role must grant access to Amazon Cognito (cognito-sync) to invoke PutRecord on your Amazon Cognito
        /// stream.
        /// Type: String
        /// Required: No
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

    }
}
