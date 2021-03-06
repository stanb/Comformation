using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.IdentityPool
{
    /// <summary>
    /// AWS::Cognito::IdentityPool PushSync
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-identitypool-pushsync.html
    /// </summary>
    public class PushSync
    {

        /// <summary>
        /// ApplicationArns
        /// The ARNs of the Amazon SNS platform applications that could be used by clients.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ApplicationArns")]
        public List<Union<string, IntrinsicFunction>> ApplicationArns { get; set; }

        /// <summary>
        /// RoleArn
        /// An IAM role configured to allow Amazon Cognito to call Amazon SNS on behalf of the developer.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

    }
}
