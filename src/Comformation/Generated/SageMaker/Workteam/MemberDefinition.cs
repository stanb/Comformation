using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.Workteam
{
    /// <summary>
    /// AWS::SageMaker::Workteam MemberDefinition
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-workteam-memberdefinition.html
    /// </summary>
    public class MemberDefinition
    {

        /// <summary>
        /// CognitoMemberDefinition
        /// The Amazon Cognito user group that is part of the work team.
        /// Required: Yes
        /// Type: CognitoMemberDefinition
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CognitoMemberDefinition")]
        public CognitoMemberDefinition CognitoMemberDefinition { get; set; }

    }
}
