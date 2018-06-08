using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPool
{
    /// <summary>
    /// Amazon Cognito UserPool LambdaConfig
    /// LambdaConfig is a property of the AWS::Cognito::UserPool resource that defines the AWS Lambda configuration of
    /// an Amazon Cognito User Pool.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-lambdaconfig.html
    /// </summary>
    public class LambdaConfig
    {

        /// <summary>
        /// CreateAuthChallenge
        /// Creates an authentication challenge.
        /// Type: String
        /// Required: No
        /// </summary>
        [JsonProperty("CreateAuthChallenge")]
        public Union<string, IntrinsicFunction> CreateAuthChallenge { get; set; }

        /// <summary>
        /// PreAuthentication
        /// A pre-authentication AWS Lambda trigger.
        /// Type: String
        /// Required: No
        /// </summary>
        [JsonProperty("PreAuthentication")]
        public Union<string, IntrinsicFunction> PreAuthentication { get; set; }

        /// <summary>
        /// DefineAuthChallenge
        /// Defines the authentication challenge.
        /// Type: String
        /// Required: No
        /// </summary>
        [JsonProperty("DefineAuthChallenge")]
        public Union<string, IntrinsicFunction> DefineAuthChallenge { get; set; }

        /// <summary>
        /// PreSignUp
        /// A pre-registration AWS Lambda trigger.
        /// Type: String
        /// Required: No
        /// </summary>
        [JsonProperty("PreSignUp")]
        public Union<string, IntrinsicFunction> PreSignUp { get; set; }

        /// <summary>
        /// PostAuthentication
        /// A post-authentication AWS Lambda trigger.
        /// Type: String
        /// Required: No
        /// </summary>
        [JsonProperty("PostAuthentication")]
        public Union<string, IntrinsicFunction> PostAuthentication { get; set; }

        /// <summary>
        /// PostConfirmation
        /// A post-confirmation AWS Lambda trigger.
        /// Type: String
        /// Required: No
        /// </summary>
        [JsonProperty("PostConfirmation")]
        public Union<string, IntrinsicFunction> PostConfirmation { get; set; }

        /// <summary>
        /// CustomMessage
        /// A custom Message AWS Lambda trigger.
        /// Type: String
        /// Required: No
        /// </summary>
        [JsonProperty("CustomMessage")]
        public Union<string, IntrinsicFunction> CustomMessage { get; set; }

        /// <summary>
        /// VerifyAuthChallengeResponse
        /// Verifies the authentication challenge response.
        /// Type: String
        /// Required: No
        /// </summary>
        [JsonProperty("VerifyAuthChallengeResponse")]
        public Union<string, IntrinsicFunction> VerifyAuthChallengeResponse { get; set; }

    }
}
