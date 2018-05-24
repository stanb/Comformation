using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPool
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-lambdaconfig.html
    /// </summary>
    public class LambdaConfig
    {

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-lambdaconfig.html#cfn-cognito-userpool-lambdaconfig-createauthchallenge
        /// </summary>
        [JsonProperty("CreateAuthChallenge")]
        public Union<string, IntrinsicFunction> CreateAuthChallenge { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-lambdaconfig.html#cfn-cognito-userpool-lambdaconfig-preauthentication
        /// </summary>
        [JsonProperty("PreAuthentication")]
        public Union<string, IntrinsicFunction> PreAuthentication { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-lambdaconfig.html#cfn-cognito-userpool-lambdaconfig-defineauthchallenge
        /// </summary>
        [JsonProperty("DefineAuthChallenge")]
        public Union<string, IntrinsicFunction> DefineAuthChallenge { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-lambdaconfig.html#cfn-cognito-userpool-lambdaconfig-presignup
        /// </summary>
        [JsonProperty("PreSignUp")]
        public Union<string, IntrinsicFunction> PreSignUp { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-lambdaconfig.html#cfn-cognito-userpool-lambdaconfig-postauthentication
        /// </summary>
        [JsonProperty("PostAuthentication")]
        public Union<string, IntrinsicFunction> PostAuthentication { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-lambdaconfig.html#cfn-cognito-userpool-lambdaconfig-postconfirmation
        /// </summary>
        [JsonProperty("PostConfirmation")]
        public Union<string, IntrinsicFunction> PostConfirmation { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-lambdaconfig.html#cfn-cognito-userpool-lambdaconfig-custommessage
        /// </summary>
        [JsonProperty("CustomMessage")]
        public Union<string, IntrinsicFunction> CustomMessage { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-lambdaconfig.html#cfn-cognito-userpool-lambdaconfig-verifyauthchallengeresponse
        /// </summary>
        [JsonProperty("VerifyAuthChallengeResponse")]
        public Union<string, IntrinsicFunction> VerifyAuthChallengeResponse { get; set; }

    }
}
