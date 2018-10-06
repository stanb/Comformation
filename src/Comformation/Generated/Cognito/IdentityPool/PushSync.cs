using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.IdentityPool
{
    /// <summary>
    /// Amazon Cognito IdentityPool PushSync
    /// PushSync is a property of the AWS::Cognito::IdentityPool resource that defines the configuration options to be
    /// applied to an Amazon Cognito identity pool.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-identitypool-pushsync.html
    /// </summary>
    public class PushSync
    {

        /// <summary>
        /// ApplicationArns
        /// List of Amazon SNS platform application ARNs that could be used by clients.
        /// Type: List of String values
        /// Required: No
        /// </summary>
        [JsonProperty("ApplicationArns")]
        public List<Union<string, IntrinsicFunction>> ApplicationArns { get; set; }

        /// <summary>
        /// RoleArn
        /// An IAM role configured to allow Amazon Cognito to call SNS on behalf of the developer.
        /// Type: String
        /// Required: No
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

    }
}
