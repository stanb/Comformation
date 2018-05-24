using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPoolClient
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolclient.html
    /// </summary>
    public class UserPoolClientResource : ResourceBase
    {
        public class UserPoolClientProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolclient.html#cfn-cognito-userpoolclient-generatesecret
            /// </summary>
			public Union<bool?, IntrinsicFunction> GenerateSecret { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolclient.html#cfn-cognito-userpoolclient-clientname
            /// </summary>
			public Union<string, IntrinsicFunction> ClientName { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolclient.html#cfn-cognito-userpoolclient-userpoolid
            /// </summary>
			public Union<string, IntrinsicFunction> UserPoolId { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolclient.html#cfn-cognito-userpoolclient-explicitauthflows
            /// </summary>
			public Union<List<string>, IntrinsicFunction> ExplicitAuthFlows { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolclient.html#cfn-cognito-userpoolclient-refreshtokenvalidity
            /// </summary>
			public Union<double?, IntrinsicFunction> RefreshTokenValidity { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolclient.html#cfn-cognito-userpoolclient-readattributes
            /// </summary>
			public Union<List<string>, IntrinsicFunction> ReadAttributes { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolclient.html#cfn-cognito-userpoolclient-writeattributes
            /// </summary>
			public Union<List<string>, IntrinsicFunction> WriteAttributes { get; set; }

        }
    
        public string Type { get; } = "AWS::Cognito::UserPoolClient";
        
        public UserPoolClientProperties Properties { get; } = new UserPoolClientProperties();
    }

	public static class UserPoolClientAttributes
	{
        public static readonly ResourceAttribute<string> ClientSecret = new ResourceAttribute<string>("ClientSecret");
        public static readonly ResourceAttribute<string> Name = new ResourceAttribute<string>("Name");
	}
}
