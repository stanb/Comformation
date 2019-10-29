using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPool
{
    /// <summary>
    /// AWS::Cognito::UserPool PasswordPolicy
    /// PasswordPolicy is a subproperty of the Policies property that defines the password policy of an Amazon Cognito
    /// user pool.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-passwordpolicy.html
    /// </summary>
    public class PasswordPolicy
    {

        /// <summary>
        /// RequireNumbers
        /// In the password policy that you have set, refers to whether you have required users to use at least
        /// one number in their password.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RequireNumbers")]
        public Union<bool, IntrinsicFunction> RequireNumbers { get; set; }

        /// <summary>
        /// MinimumLength
        /// The minimum length of the password policy that you have set. Cannot be less than 6.
        /// Required: No
        /// Type: Integer
        /// Minimum: 6
        /// Maximum: 99
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MinimumLength")]
        public Union<int, IntrinsicFunction> MinimumLength { get; set; }

        /// <summary>
        /// TemporaryPasswordValidityDays
        /// In the password policy you have set, refers to the number of days a temporary password is valid. If
        /// the user does not sign-in during this time, their password will need to be reset by an
        /// administrator.
        /// Note When you set TemporaryPasswordValidityDays for a user pool, you will no longer be able to set
        /// the deprecated UnusedAccountValidityDays value for that user pool.
        /// Required: No
        /// Type: Integer
        /// Minimum: 0
        /// Maximum: 365
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TemporaryPasswordValidityDays")]
        public Union<int, IntrinsicFunction> TemporaryPasswordValidityDays { get; set; }

        /// <summary>
        /// RequireUppercase
        /// In the password policy that you have set, refers to whether you have required users to use at least
        /// one uppercase letter in their password.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RequireUppercase")]
        public Union<bool, IntrinsicFunction> RequireUppercase { get; set; }

        /// <summary>
        /// RequireLowercase
        /// In the password policy that you have set, refers to whether you have required users to use at least
        /// one lowercase letter in their password.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RequireLowercase")]
        public Union<bool, IntrinsicFunction> RequireLowercase { get; set; }

        /// <summary>
        /// RequireSymbols
        /// In the password policy that you have set, refers to whether you have required users to use at least
        /// one symbol in their password.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RequireSymbols")]
        public Union<bool, IntrinsicFunction> RequireSymbols { get; set; }

    }
}
