using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPool
{
    /// <summary>
    /// AWS::Cognito::UserPool
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html
    /// </summary>
    public class UserPoolResource : ResourceBase
    {
        public class UserPoolProperties
        {
            /// <summary>
            /// UserPoolTags
            /// The tag keys and values to assign to the user pool. A tag is a label that you can use to categorize
            /// and manage user pools in different ways, such as by purpose, owner, environment, or other criteria.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> UserPoolTags { get; set; }

            /// <summary>
            /// Policies
            /// The policy associated with a user pool.
            /// Required: No
            /// Type: Policies
            /// Update requires: No interruption
            /// </summary>
            public Policies Policies { get; set; }

            /// <summary>
            /// VerificationMessageTemplate
            /// The template for the verification message that the user sees when the app requests permission to
            /// access the user&#39;s information.
            /// Required: No
            /// Type: VerificationMessageTemplate
            /// Update requires: No interruption
            /// </summary>
            public VerificationMessageTemplate VerificationMessageTemplate { get; set; }

            /// <summary>
            /// MfaConfiguration
            /// The multi-factor (MFA) configuration. Valid values include:
            /// OFF MFA will not be used for any users. ON MFA is required for all users to sign in. OPTIONAL MFA
            /// will be required only for individual users who have an MFA factor enabled.
            /// Required: No
            /// Type: String
            /// Allowed values: OFF | ON | OPTIONAL
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> MfaConfiguration { get; set; }

            /// <summary>
            /// Schema
            /// The schema attributes for the new user pool. These attributes can be standard or custom attributes.
            /// Note During a user pool update, you can add new schema attributes but you cannot modify or delete an
            /// existing schema attribute.
            /// Required: No
            /// Type: List of SchemaAttribute
            /// Maximum: 50
            /// Update requires: No interruption
            /// </summary>
            public List<SchemaAttribute> Schema { get; set; }

            /// <summary>
            /// AdminCreateUserConfig
            /// The configuration for creating a new user profile.
            /// Required: No
            /// Type: AdminCreateUserConfig
            /// Update requires: No interruption
            /// </summary>
            public AdminCreateUserConfig AdminCreateUserConfig { get; set; }

            /// <summary>
            /// SmsAuthenticationMessage
            /// A string representing the SMS authentication message.
            /// Required: No
            /// Type: String
            /// Minimum: 6
            /// Maximum: 140
            /// Pattern: . *\{####\}. *
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> SmsAuthenticationMessage { get; set; }

            /// <summary>
            /// UsernameConfiguration
            /// You can choose to set case sensitivity on the username input for the selected sign-in option. For
            /// example, when this is set to False, users will be able to sign in using either &quot;username&quot; or
            /// &quot;Username&quot;. This configuration is immutable once it has been set.
            /// Required: No
            /// Type: UsernameConfiguration
            /// Update requires: No interruption
            /// </summary>
            public UsernameConfiguration UsernameConfiguration { get; set; }

            /// <summary>
            /// UserPoolName
            /// A string used to name the user pool.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Pattern: [\w\s+=,. @-]+
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> UserPoolName { get; set; }

            /// <summary>
            /// SmsVerificationMessage
            /// A string representing the SMS verification message.
            /// Required: No
            /// Type: String
            /// Minimum: 6
            /// Maximum: 140
            /// Pattern: . *\{####\}. *
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> SmsVerificationMessage { get; set; }

            /// <summary>
            /// UserPoolAddOns
            /// Used to enable advanced security risk detection. Set the key AdvancedSecurityMode to the value
            /// &quot;AUDIT&quot;.
            /// Required: No
            /// Type: UserPoolAddOns
            /// Update requires: No interruption
            /// </summary>
            public UserPoolAddOns UserPoolAddOns { get; set; }

            /// <summary>
            /// EmailConfiguration
            /// The email configuration.
            /// Required: No
            /// Type: EmailConfiguration
            /// Update requires: No interruption
            /// </summary>
            public EmailConfiguration EmailConfiguration { get; set; }

            /// <summary>
            /// SmsConfiguration
            /// The SMS configuration.
            /// Required: No
            /// Type: SmsConfiguration
            /// Update requires: No interruption
            /// </summary>
            public SmsConfiguration SmsConfiguration { get; set; }

            /// <summary>
            /// AliasAttributes
            /// Attributes supported as an alias for this user pool. Possible values: phone_number, email, or
            /// preferred_username.
            /// Note This user pool property cannot be updated.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> AliasAttributes { get; set; }

            /// <summary>
            /// EnabledMfas
            /// Enables MFA on a specified user pool. To disable all MFAs after it has been enabled, set
            /// MfaConfiguration to “OFF” and remove EnabledMfas. MFAs can only be all disabled if MfaConfiguration
            /// is OFF. Once SMS_MFA is enabled, SMS_MFA can only be disabled by setting MfaConfiguration to “OFF”.
            /// Can be one of the following values:
            /// SMS_MFA - Enables SMS MFA for the user pool. SMS_MFA can only be enabled if SMS configuration is
            /// provided. SOFTWARE_TOKEN_MFA - Enables software token MFA for the user pool.
            /// Allowed values: SMS_MFA | SOFTWARE_TOKEN_MFA
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> EnabledMfas { get; set; }

            /// <summary>
            /// EmailVerificationSubject
            /// A string representing the email verification subject. EmailVerificationSubject is allowed only if
            /// EmailSendingAccount is DEVELOPER.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 140
            /// Pattern: [\p{L}\p{M}\p{S}\p{N}\p{P}\s]+
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> EmailVerificationSubject { get; set; }

            /// <summary>
            /// LambdaConfig
            /// The Lambda trigger configuration information for the new user pool.
            /// Note In a push model, event sources (such as Amazon S3 and custom applications) need permission to
            /// invoke a function. So you will need to make an extra call to add permission for these event sources
            /// to invoke your Lambda function. For more information on using the Lambda API to add permission, see
            /// AddPermission . For adding permission using the AWS CLI, see add-permission .
            /// Required: No
            /// Type: LambdaConfig
            /// Update requires: No interruption
            /// </summary>
            public LambdaConfig LambdaConfig { get; set; }

            /// <summary>
            /// UsernameAttributes
            /// Determines whether email addresses or phone numbers can be specified as user names when a user signs
            /// up. Possible values: phone_number or email.
            /// This user pool property cannot be updated.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> UsernameAttributes { get; set; }

            /// <summary>
            /// AutoVerifiedAttributes
            /// The attributes to be auto-verified. Possible values: email, phone_number.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> AutoVerifiedAttributes { get; set; }

            /// <summary>
            /// DeviceConfiguration
            /// The device configuration.
            /// Required: No
            /// Type: DeviceConfiguration
            /// Update requires: No interruption
            /// </summary>
            public DeviceConfiguration DeviceConfiguration { get; set; }

            /// <summary>
            /// EmailVerificationMessage
            /// A string representing the email verification message. EmailVerificationMessage is allowed only if
            /// EmailSendingAccount is DEVELOPER.
            /// Required: No
            /// Type: String
            /// Minimum: 6
            /// Maximum: 20000
            /// Pattern: [\p{L}\p{M}\p{S}\p{N}\p{P}\s*]*\{####\}[\p{L}\p{M}\p{S}\p{N}\p{P}\s*]*
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> EmailVerificationMessage { get; set; }

            /// <summary>
            /// AccountRecoverySetting
            /// Use this setting to define which verified available method a user can use to recover their password
            /// when they call ForgotPassword. It allows you to define a preferred method when a user has more than
            /// one method available. With this setting, SMS does not qualify for a valid password recovery
            /// mechanism if the user also has SMS MFA enabled. In the absence of this setting, Cognito uses the
            /// legacy behavior to determine the recovery method where SMS is preferred over email.
            /// Required: No
            /// Type: AccountRecoverySetting
            /// Update requires: No interruption
            /// </summary>
            public AccountRecoverySetting AccountRecoverySetting { get; set; }

        }

        public string Type { get; } = "AWS::Cognito::UserPool";

        public UserPoolProperties Properties { get; } = new UserPoolProperties();

    }

    public static class UserPoolAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ProviderName = new ResourceAttribute<Union<string, IntrinsicFunction>>("ProviderName");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ProviderURL = new ResourceAttribute<Union<string, IntrinsicFunction>>("ProviderURL");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
