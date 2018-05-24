using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGateway.Account
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-account.html
    /// </summary>
    public class AccountResource : ResourceBase
    {
        public class AccountProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-account.html#cfn-apigateway-account-cloudwatchrolearn
            /// </summary>
			public Union<string, IntrinsicFunction> CloudWatchRoleArn { get; set; }

        }
    
        public string Type { get; } = "AWS::ApiGateway::Account";
        
        public AccountProperties Properties { get; } = new AccountProperties();
    }
}
