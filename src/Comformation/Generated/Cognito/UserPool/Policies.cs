using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPool
{
    /// <summary>
    /// Amazon Cognito UserPool Policies
    /// Policies is a property of the AWS::Cognito::UserPool resource that defines the password policies of an Amazon
    /// Cognito User Pool.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-policies.html
    /// </summary>
    public class Policies
    {

        /// <summary>
        /// PasswordPolicy
        /// Specifies information about the user pool password policy.
        /// Type: Amazon Cognito UserPool PasswordPolicy
        /// Required: No
        /// </summary>
        [JsonProperty("PasswordPolicy")]
        public PasswordPolicy PasswordPolicy { get; set; }

    }
}
