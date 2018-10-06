using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPoolClient
{
    /// <summary>
    /// AWS::Cognito::UserPoolClient
    /// The AWS::Cognito::UserPoolClient resource creates an Amazon Cognito user pool client.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolclient.html
    /// </summary>
    public class UserPoolClientResource : ResourceBase
    {
        public class UserPoolClientProperties
        {
            /// <summary>
            /// GenerateSecret
            /// Specifies whether you want to generate a secret for the user pool client being created.
            /// Required: No
            /// Type: Boolean
            /// Update requires: Replacement
            /// </summary>
			public Union<bool, IntrinsicFunction> GenerateSecret { get; set; }

            /// <summary>
            /// ClientName
            /// The client name for the user pool client that you want to create.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// MinLength: 1
            /// MaxLength: 128
            /// </summary>
			public Union<string, IntrinsicFunction> ClientName { get; set; }

            /// <summary>
            /// UserPoolId
            /// The user pool ID for the user pool where you want to create a client.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> UserPoolId { get; set; }

            /// <summary>
            /// ExplicitAuthFlows
            /// The explicit authentication flows, which can be one of the following: ADMIN_NO_SRP_AUTH,
            /// CUSTOM_AUTH_FLOW_ONLY, or USER_PASSWORD_AUTH.
            /// Required: No
            /// Type: List of Strings
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> ExplicitAuthFlows { get; set; }

            /// <summary>
            /// RefreshTokenValidity
            /// The time limit, in days, after which the refresh token is no longer valid.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<double, IntrinsicFunction> RefreshTokenValidity { get; set; }

            /// <summary>
            /// ReadAttributes
            /// The read attributes.
            /// Required: No
            /// Type: List of Strings
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> ReadAttributes { get; set; }

            /// <summary>
            /// WriteAttributes
            /// The write attributes.
            /// Required: No
            /// Type: List of Strings
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> WriteAttributes { get; set; }

        }
    
        public string Type { get; } = "AWS::Cognito::UserPoolClient";
        
        public UserPoolClientProperties Properties { get; } = new UserPoolClientProperties();

    }

	public static class UserPoolClientAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ClientSecret = new ResourceAttribute<Union<string, IntrinsicFunction>>("ClientSecret");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Name = new ResourceAttribute<Union<string, IntrinsicFunction>>("Name");
	}
}
