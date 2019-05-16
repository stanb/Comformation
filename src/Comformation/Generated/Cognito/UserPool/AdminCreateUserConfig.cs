using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPool
{
    /// <summary>
    /// AWS::Cognito::UserPool AdminCreateUserConfig
    /// AdminCreateUserConfig is a property of the AWS::Cognito::UserPool resource. The AdminCreateUserConfig property
    /// configures the AdminCreateUser requests for an Amazon Cognito User Pool.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-admincreateuserconfig.html
    /// </summary>
    public class AdminCreateUserConfig
    {

        /// <summary>
        /// InviteMessageTemplate
        /// The message template to be used for the welcome message to new users.
        /// See also Customizing User Invitation Messages.
        /// Required: No
        /// Type: InviteMessageTemplate
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InviteMessageTemplate")]
        public InviteMessageTemplate InviteMessageTemplate { get; set; }

        /// <summary>
        /// UnusedAccountValidityDays
        /// The user account expiration limit, in days, after which the account is no longer usable. To reset
        /// the account after that time limit, you must call AdminCreateUser again, specifying &quot;RESEND&quot; for the
        /// MessageAction parameter. The default value for this parameter is 7.
        /// Note If you set a value for TemporaryPasswordValidityDays in PasswordPolicy, that value will be used
        /// and UnusedAccountValidityDays will be deprecated for that user pool.
        /// Required: No
        /// Type: Double
        /// Minimum: 0
        /// Maximum: 365
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UnusedAccountValidityDays")]
        public Union<double, IntrinsicFunction> UnusedAccountValidityDays { get; set; }

        /// <summary>
        /// AllowAdminCreateUserOnly
        /// Set to True if only the administrator is allowed to create user profiles. Set to False if users can
        /// sign themselves up via an app.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AllowAdminCreateUserOnly")]
        public Union<bool, IntrinsicFunction> AllowAdminCreateUserOnly { get; set; }

    }
}
