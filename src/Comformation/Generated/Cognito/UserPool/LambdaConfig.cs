using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPool
{
    /// <summary>
    /// AWS::Cognito::UserPool LambdaConfig
    /// LambdaConfig is a property of the AWS::Cognito::UserPool resource that defines the AWS Lambda configuration of
    /// an Amazon Cognito user pool.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-lambdaconfig.html
    /// </summary>
    public class LambdaConfig
    {

        /// <summary>
        /// CreateAuthChallenge
        /// Creates an authentication challenge.
        /// Required: No
        /// Type: String
        /// Minimum: 20
        /// Maximum: 2048
        /// Pattern: arn:[\w+=/,. @-]+:[\w+=/,. @-]+:([\w+=/,. @-]*)?:[0-9]+:[\w+=/,. @-]+(:[\w+=/,.
        /// @-]+)?(:[\w+=/,. @-]+)?
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CreateAuthChallenge")]
        public Union<string, IntrinsicFunction> CreateAuthChallenge { get; set; }

        /// <summary>
        /// PreAuthentication
        /// A pre-authentication AWS Lambda trigger.
        /// Required: No
        /// Type: String
        /// Minimum: 20
        /// Maximum: 2048
        /// Pattern: arn:[\w+=/,. @-]+:[\w+=/,. @-]+:([\w+=/,. @-]*)?:[0-9]+:[\w+=/,. @-]+(:[\w+=/,.
        /// @-]+)?(:[\w+=/,. @-]+)?
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PreAuthentication")]
        public Union<string, IntrinsicFunction> PreAuthentication { get; set; }

        /// <summary>
        /// DefineAuthChallenge
        /// Defines the authentication challenge.
        /// Required: No
        /// Type: String
        /// Minimum: 20
        /// Maximum: 2048
        /// Pattern: arn:[\w+=/,. @-]+:[\w+=/,. @-]+:([\w+=/,. @-]*)?:[0-9]+:[\w+=/,. @-]+(:[\w+=/,.
        /// @-]+)?(:[\w+=/,. @-]+)?
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DefineAuthChallenge")]
        public Union<string, IntrinsicFunction> DefineAuthChallenge { get; set; }

        /// <summary>
        /// PreSignUp
        /// A pre-registration AWS Lambda trigger.
        /// Required: No
        /// Type: String
        /// Minimum: 20
        /// Maximum: 2048
        /// Pattern: arn:[\w+=/,. @-]+:[\w+=/,. @-]+:([\w+=/,. @-]*)?:[0-9]+:[\w+=/,. @-]+(:[\w+=/,.
        /// @-]+)?(:[\w+=/,. @-]+)?
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PreSignUp")]
        public Union<string, IntrinsicFunction> PreSignUp { get; set; }

        /// <summary>
        /// PreTokenGeneration
        /// A Lambda trigger that is invoked before token generation.
        /// Required: No
        /// Type: String
        /// Minimum: 20
        /// Maximum: 2048
        /// Pattern: arn:[\w+=/,. @-]+:[\w+=/,. @-]+:([\w+=/,. @-]*)?:[0-9]+:[\w+=/,. @-]+(:[\w+=/,.
        /// @-]+)?(:[\w+=/,. @-]+)?
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PreTokenGeneration")]
        public Union<string, IntrinsicFunction> PreTokenGeneration { get; set; }

        /// <summary>
        /// UserMigration
        /// The user migration Lambda config type.
        /// Required: No
        /// Type: String
        /// Minimum: 20
        /// Maximum: 2048
        /// Pattern: arn:[\w+=/,. @-]+:[\w+=/,. @-]+:([\w+=/,. @-]*)?:[0-9]+:[\w+=/,. @-]+(:[\w+=/,.
        /// @-]+)?(:[\w+=/,. @-]+)?
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UserMigration")]
        public Union<string, IntrinsicFunction> UserMigration { get; set; }

        /// <summary>
        /// PostAuthentication
        /// A post-authentication AWS Lambda trigger.
        /// Required: No
        /// Type: String
        /// Minimum: 20
        /// Maximum: 2048
        /// Pattern: arn:[\w+=/,. @-]+:[\w+=/,. @-]+:([\w+=/,. @-]*)?:[0-9]+:[\w+=/,. @-]+(:[\w+=/,.
        /// @-]+)?(:[\w+=/,. @-]+)?
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PostAuthentication")]
        public Union<string, IntrinsicFunction> PostAuthentication { get; set; }

        /// <summary>
        /// PostConfirmation
        /// A post-confirmation AWS Lambda trigger.
        /// Required: No
        /// Type: String
        /// Minimum: 20
        /// Maximum: 2048
        /// Pattern: arn:[\w+=/,. @-]+:[\w+=/,. @-]+:([\w+=/,. @-]*)?:[0-9]+:[\w+=/,. @-]+(:[\w+=/,.
        /// @-]+)?(:[\w+=/,. @-]+)?
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PostConfirmation")]
        public Union<string, IntrinsicFunction> PostConfirmation { get; set; }

        /// <summary>
        /// CustomMessage
        /// A custom Message AWS Lambda trigger.
        /// Required: No
        /// Type: String
        /// Minimum: 20
        /// Maximum: 2048
        /// Pattern: arn:[\w+=/,. @-]+:[\w+=/,. @-]+:([\w+=/,. @-]*)?:[0-9]+:[\w+=/,. @-]+(:[\w+=/,.
        /// @-]+)?(:[\w+=/,. @-]+)?
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CustomMessage")]
        public Union<string, IntrinsicFunction> CustomMessage { get; set; }

        /// <summary>
        /// VerifyAuthChallengeResponse
        /// Verifies the authentication challenge response.
        /// Required: No
        /// Type: String
        /// Minimum: 20
        /// Maximum: 2048
        /// Pattern: arn:[\w+=/,. @-]+:[\w+=/,. @-]+:([\w+=/,. @-]*)?:[0-9]+:[\w+=/,. @-]+(:[\w+=/,.
        /// @-]+)?(:[\w+=/,. @-]+)?
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VerifyAuthChallengeResponse")]
        public Union<string, IntrinsicFunction> VerifyAuthChallengeResponse { get; set; }

    }
}
