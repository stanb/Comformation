using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.Workteam
{
    /// <summary>
    /// AWS::SageMaker::Workteam CognitoMemberDefinition
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-workteam-cognitomemberdefinition.html
    /// </summary>
    public class CognitoMemberDefinition
    {

        /// <summary>
        /// CognitoUserPool
        /// Not currently supported by AWS CloudFormation.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("CognitoUserPool")]
        public Union<string, IntrinsicFunction> CognitoUserPool { get; set; }

        /// <summary>
        /// CognitoClientId
        /// Not currently supported by AWS CloudFormation.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CognitoClientId")]
        public Union<string, IntrinsicFunction> CognitoClientId { get; set; }

        /// <summary>
        /// CognitoUserGroup
        /// Not currently supported by AWS CloudFormation.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CognitoUserGroup")]
        public Union<string, IntrinsicFunction> CognitoUserGroup { get; set; }

    }
}
