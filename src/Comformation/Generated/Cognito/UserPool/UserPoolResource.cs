using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPool
{
    /// <summary>
    /// AWS::Cognito::UserPool
    /// The AWS::Cognito::UserPool resource creates an Amazon Cognito user pool. For more information on working with
    /// Amazon Cognito user pools, see Amazon Cognito User Pools and CreateUserPool.
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
            /// MfaConfiguration
            /// Specifies multi-factor authentication (MFA) configuration details. Can be one of the following
            /// values:
            /// OFF - MFA tokens are not required and cannot be specified during user registration.
            /// ON - MFA tokens are required for all user registrations. You can only specify required when you are
            /// initially creating a user pool.
            /// OPTIONAL - Users have the option when registering to create an MFA token.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> MfaConfiguration { get; set; }

            /// <summary>
            /// Schema
            /// An array of schema attributes for the new user pool. These attributes can be standard or custom
            /// attributes.
            /// Required: No
            /// Type: List of SchemaAttribute
            /// Maximum: 50
            /// Update requires: Replacement
            /// </summary>
			public List<SchemaAttribute> Schema { get; set; }

            /// <summary>
            /// AdminCreateUserConfig
            /// The type of configuration for creating a new user profile.
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
            /// UserPoolName
            /// A string used to name the user pool.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Pattern: [\w\s+=,. @-]+
            /// Update requires: Replacement
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
            /// Required: No
            /// Type: List of String
            /// Update requires: Replacement
            /// </summary>
			public List<Union<string, IntrinsicFunction>> AliasAttributes { get; set; }

            /// <summary>
            /// EmailVerificationSubject
            /// A string representing the email verification subject.
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
            /// Specifies whether email addresses or phone numbers can be specified as user names when a user signs
            /// up. Possible values: phone_number or email.
            /// Required: No
            /// Type: List of String
            /// Update requires: Replacement
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
            /// The type of configuration for the user pool&#39;s device tracking.
            /// Required: No
            /// Type: DeviceConfiguration
            /// Update requires: No interruption
            /// </summary>
			public DeviceConfiguration DeviceConfiguration { get; set; }

            /// <summary>
            /// EmailVerificationMessage
            /// A string representing the email verification message.
            /// Required: No
            /// Type: String
            /// Minimum: 6
            /// Maximum: 20000
            /// Pattern: [\p{L}\p{M}\p{S}\p{N}\p{P}\s*]*\{####\}[\p{L}\p{M}\p{S}\p{N}\p{P}\s*]*
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> EmailVerificationMessage { get; set; }

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
