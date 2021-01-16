using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPool
{
    /// <summary>
    /// AWS::Cognito::UserPool Policies
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-policies.html
    /// </summary>
    public class Policies
    {

        /// <summary>
        /// PasswordPolicy
        /// The password policy.
        /// Required: No
        /// Type: PasswordPolicy
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PasswordPolicy")]
        public PasswordPolicy PasswordPolicy { get; set; }

    }
}
