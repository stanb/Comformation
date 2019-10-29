using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.Workteam
{
    /// <summary>
    /// AWS::SageMaker::Workteam CognitoMemberDefinition
    /// Identifies a Amazon Cognito user group. A user group can be used in on or more work teams.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-workteam-cognitomemberdefinition.html
    /// </summary>
    public class CognitoMemberDefinition
    {

        /// <summary>
        /// CognitoUserPool
        /// An identifier for a user pool. The user pool must be in the same region as the service that you are
        /// calling.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 55
        /// Pattern: [\w-]+_[0-9a-zA-Z]+
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("CognitoUserPool")]
        public Union<string, IntrinsicFunction> CognitoUserPool { get; set; }

        /// <summary>
        /// CognitoClientId
        /// An identifier for an application client. You must create the app client ID using Amazon Cognito.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 128
        /// Pattern: [\w+]+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CognitoClientId")]
        public Union<string, IntrinsicFunction> CognitoClientId { get; set; }

        /// <summary>
        /// CognitoUserGroup
        /// An identifier for a user group.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 128
        /// Pattern: [\p{L}\p{M}\p{S}\p{N}\p{P}]+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CognitoUserGroup")]
        public Union<string, IntrinsicFunction> CognitoUserGroup { get; set; }

    }
}
