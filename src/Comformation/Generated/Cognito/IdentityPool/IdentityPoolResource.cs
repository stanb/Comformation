using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.IdentityPool
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-identitypool.html
    /// </summary>
    public class IdentityPoolResource : ResourceBase
    {
        public class IdentityPoolProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-identitypool.html#cfn-cognito-identitypool-pushsync
            /// </summary>
			public Union<PushSync, IntrinsicFunction> PushSync { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-identitypool.html#cfn-cognito-identitypool-cognitoidentityproviders
            /// </summary>
			public Union<List<CognitoIdentityProvider>, IntrinsicFunction> CognitoIdentityProviders { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-identitypool.html#cfn-cognito-identitypool-cognitoevents
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> CognitoEvents { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-identitypool.html#cfn-cognito-identitypool-developerprovidername
            /// </summary>
			public Union<string, IntrinsicFunction> DeveloperProviderName { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-identitypool.html#cfn-cognito-identitypool-cognitostreams
            /// </summary>
			public Union<CognitoStreams, IntrinsicFunction> CognitoStreams { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-identitypool.html#cfn-cognito-identitypool-identitypoolname
            /// </summary>
			public Union<string, IntrinsicFunction> IdentityPoolName { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-identitypool.html#cfn-cognito-identitypool-allowunauthenticatedidentities
            /// </summary>
			public Union<bool, IntrinsicFunction> AllowUnauthenticatedIdentities { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-identitypool.html#cfn-cognito-identitypool-supportedloginproviders
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> SupportedLoginProviders { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-identitypool.html#cfn-cognito-identitypool-samlproviderarns
            /// </summary>
			public Union<List<string>, IntrinsicFunction> SamlProviderARNs { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-identitypool.html#cfn-cognito-identitypool-openidconnectproviderarns
            /// </summary>
			public Union<List<string>, IntrinsicFunction> OpenIdConnectProviderARNs { get; set; }

        }
    
        public string Type { get; } = "AWS::Cognito::IdentityPool";
        
        public IdentityPoolProperties Properties { get; } = new IdentityPoolProperties();
    }

	public static class IdentityPoolAttributes
	{
        public static readonly ResourceAttribute<string> Name = new ResourceAttribute<string>("Name");
	}
}
