using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPool
{
    /// <summary>
    /// Amazon Cognito UserPool PasswordPolicy
    /// PasswordPolicy is a subproperty of the Amazon Cognito UserPool Policies property that defines the password
    /// policy of an Amazon Cognito User Pool.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-passwordpolicy.html
    /// </summary>
    public class PasswordPolicy
    {

        /// <summary>
        /// RequireNumbers
        /// In the password policy that you have set, refers to whether you have required users to use at least
        /// one number in their password.
        /// Type: Boolean
        /// Required: No
        /// </summary>
        [JsonProperty("RequireNumbers")]
        public Union<bool, IntrinsicFunction> RequireNumbers { get; set; }

        /// <summary>
        /// MinimumLength
        /// The minimum length of the password policy that you have set. Cannot be less than 6.
        /// Type: Integer
        /// Required: No
        /// </summary>
        [JsonProperty("MinimumLength")]
        public Union<int, IntrinsicFunction> MinimumLength { get; set; }

        /// <summary>
        /// RequireUppercase
        /// In the password policy that you have set, refers to whether you have required users to use at least
        /// one uppercase letter in their password.
        /// Type: Boolean
        /// Required: No
        /// </summary>
        [JsonProperty("RequireUppercase")]
        public Union<bool, IntrinsicFunction> RequireUppercase { get; set; }

        /// <summary>
        /// RequireLowercase
        /// In the password policy that you have set, refers to whether you have required users to use at least
        /// one lowercase letter in their password.
        /// Type: Boolean
        /// Required: No
        /// </summary>
        [JsonProperty("RequireLowercase")]
        public Union<bool, IntrinsicFunction> RequireLowercase { get; set; }

        /// <summary>
        /// RequireSymbols
        /// In the password policy that you have set, refers to whether you have required users to use at least
        /// one symbol in their password.
        /// Type: Boolean
        /// Required: No
        /// </summary>
        [JsonProperty("RequireSymbols")]
        public Union<bool, IntrinsicFunction> RequireSymbols { get; set; }

    }
}
