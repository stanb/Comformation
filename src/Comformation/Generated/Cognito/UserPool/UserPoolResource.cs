using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPool
{
    /// <summary>
    /// AWS::Cognito::UserPool
    /// The AWS::Cognito::UserPool resource creates an Amazon Cognito user pool. For more information on working with
    /// Amazon Cognito user pools, see Amazon Cognito User Pools and CreateUserPool.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html
    /// </summary>
    public class UserPoolResource : ResourceBase
    {
        public class UserPoolProperties
        {
            /// <summary>
            /// UserPoolTags
            /// The cost allocation tags for the user pool. For more information, see Adding Cost Allocation Tags to
            /// Your User Pool in the Amazon Cognito Developer Guide.
            /// Required: No
            /// Type: String to String map
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-userpooltags
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> UserPoolTags { get; set; }

            /// <summary>
            /// Policies
            /// The policies associated with the Amazon Cognito user pool.
            /// Required: No
            /// Type: Amazon Cognito UserPool Policies
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-policies
            /// </summary>
			public Union<Policies, IntrinsicFunction> Policies { get; set; }

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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-mfaconfiguration
            /// </summary>
			public Union<string, IntrinsicFunction> MfaConfiguration { get; set; }

            /// <summary>
            /// Schema
            /// A list of schema attributes for the new user pool. These attributes can be standard or custom
            /// attributes.
            /// Required: No
            /// Type: List of SchemaAttribute
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-schema
            /// </summary>
			public Union<List<SchemaAttribute>, IntrinsicFunction> Schema { get; set; }

            /// <summary>
            /// AdminCreateUserConfig
            /// The type of configuration for creating a new user profile.
            /// Required: No
            /// Type: Amazon Cognito UserPool AdminCreateUserConfig
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-admincreateuserconfig
            /// </summary>
			public Union<AdminCreateUserConfig, IntrinsicFunction> AdminCreateUserConfig { get; set; }

            /// <summary>
            /// SmsAuthenticationMessage
            /// A string representing the SMS authentication message. Must contain {####} in the message.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-smsauthenticationmessage
            /// </summary>
			public Union<string, IntrinsicFunction> SmsAuthenticationMessage { get; set; }

            /// <summary>
            /// UserPoolName
            /// A string used to name the user pool.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-poolname
            /// </summary>
			public Union<string, IntrinsicFunction> UserPoolName { get; set; }

            /// <summary>
            /// SmsVerificationMessage
            /// A string representing the SMS verification message. Must contain {####} in the message.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-smsverificationmessage
            /// </summary>
			public Union<string, IntrinsicFunction> SmsVerificationMessage { get; set; }

            /// <summary>
            /// EmailConfiguration
            /// The email configuration.
            /// Required: No
            /// Type: Amazon Cognito UserPool EmailConfiguration
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-emailconfiguration
            /// </summary>
			public Union<EmailConfiguration, IntrinsicFunction> EmailConfiguration { get; set; }

            /// <summary>
            /// SmsConfiguration
            /// The Short Message Service (SMS) configuration.
            /// Required: No
            /// Type: Amazon Cognito UserPool SmsConfiguration
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-smsconfiguration
            /// </summary>
			public Union<SmsConfiguration, IntrinsicFunction> SmsConfiguration { get; set; }

            /// <summary>
            /// AliasAttributes
            /// Attributes supported as an alias for this user pool. Possible values: phone_number, email, and/or
            /// preferred_username.
            /// Required: No
            /// Type: List of String values
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-aliasattributes
            /// </summary>
			public Union<List<string>, IntrinsicFunction> AliasAttributes { get; set; }

            /// <summary>
            /// EmailVerificationSubject
            /// A string representing the email verification subject.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-emailverificationsubject
            /// </summary>
			public Union<string, IntrinsicFunction> EmailVerificationSubject { get; set; }

            /// <summary>
            /// LambdaConfig
            /// The AWS Lambda trigger configuration information for the Amazon Cognito user pool.
            /// Required: No
            /// Type: Amazon Cognito UserPool LambdaConfig
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-lambdaconfig
            /// </summary>
			public Union<LambdaConfig, IntrinsicFunction> LambdaConfig { get; set; }

            /// <summary>
            /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-usernameattributes
            /// </summary>
			public Union<List<string>, IntrinsicFunction> UsernameAttributes { get; set; }

            /// <summary>
            /// AutoVerifiedAttributes
            /// The attributes to be auto-verified. Possible values: email and/or phone_number.
            /// Required: No
            /// Type: List of String values
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-autoverifiedattributes
            /// </summary>
			public Union<List<string>, IntrinsicFunction> AutoVerifiedAttributes { get; set; }

            /// <summary>
            /// DeviceConfiguration
            /// The type of configuration for the user pool's device tracking.
            /// Required: No
            /// Type: Amazon Cognito UserPool DeviceConfiguration
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-deviceconfiguration
            /// </summary>
			public Union<DeviceConfiguration, IntrinsicFunction> DeviceConfiguration { get; set; }

            /// <summary>
            /// EmailVerificationMessage
            /// A string representing the email verification message. Must contain {####} in the description.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-emailverificationmessage
            /// </summary>
			public Union<string, IntrinsicFunction> EmailVerificationMessage { get; set; }

        }
    
        public string Type { get; } = "AWS::Cognito::UserPool";
        
        public UserPoolProperties Properties { get; } = new UserPoolProperties();
    }

	public static class UserPoolAttributes
	{
        public static readonly ResourceAttribute<string> ProviderName = new ResourceAttribute<string>("ProviderName");
        public static readonly ResourceAttribute<string> ProviderURL = new ResourceAttribute<string>("ProviderURL");
        public static readonly ResourceAttribute<string> Arn = new ResourceAttribute<string>("Arn");
	}
}
