using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPool
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html
    /// </summary>
    public class UserPoolResource : ResourceBase
    {
        public class UserPoolProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-userpooltags
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> UserPoolTags { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-policies
            /// </summary>
			public Union<Policies, IntrinsicFunction> Policies { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-mfaconfiguration
            /// </summary>
			public Union<string, IntrinsicFunction> MfaConfiguration { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-schema
            /// </summary>
			public Union<List<SchemaAttribute>, IntrinsicFunction> Schema { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-admincreateuserconfig
            /// </summary>
			public Union<AdminCreateUserConfig, IntrinsicFunction> AdminCreateUserConfig { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-smsauthenticationmessage
            /// </summary>
			public Union<string, IntrinsicFunction> SmsAuthenticationMessage { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-userpoolname
            /// </summary>
			public Union<string, IntrinsicFunction> UserPoolName { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-smsverificationmessage
            /// </summary>
			public Union<string, IntrinsicFunction> SmsVerificationMessage { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-emailconfiguration
            /// </summary>
			public Union<EmailConfiguration, IntrinsicFunction> EmailConfiguration { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-smsconfiguration
            /// </summary>
			public Union<SmsConfiguration, IntrinsicFunction> SmsConfiguration { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-aliasattributes
            /// </summary>
			public Union<List<string>, IntrinsicFunction> AliasAttributes { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-emailverificationsubject
            /// </summary>
			public Union<string, IntrinsicFunction> EmailVerificationSubject { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-lambdaconfig
            /// </summary>
			public Union<LambdaConfig, IntrinsicFunction> LambdaConfig { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-usernameattributes
            /// </summary>
			public Union<List<string>, IntrinsicFunction> UsernameAttributes { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-autoverifiedattributes
            /// </summary>
			public Union<List<string>, IntrinsicFunction> AutoVerifiedAttributes { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-deviceconfiguration
            /// </summary>
			public Union<DeviceConfiguration, IntrinsicFunction> DeviceConfiguration { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-emailverificationmessage
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
