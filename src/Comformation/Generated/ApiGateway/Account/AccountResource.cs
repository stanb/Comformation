using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGateway.Account
{
    /// <summary>
    /// AWS::ApiGateway::Account
    /// The AWS::ApiGateway::Account resource specifies the AWS Identity and Access Management (IAM) role that Amazon
    /// API Gateway (API Gateway) uses to write API logs to Amazon CloudWatch Logs (CloudWatch Logs).
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-account.html
    /// </summary>
    public class AccountResource : ResourceBase
    {
        public class AccountProperties
        {
            /// <summary>
            /// CloudWatchRoleArn
            /// The Amazon Resource Name (ARN) of an IAM role that has write access to CloudWatch Logs in your
            /// account.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> CloudWatchRoleArn { get; set; }

        }
    
        public string Type { get; } = "AWS::ApiGateway::Account";
        
        public AccountProperties Properties { get; } = new AccountProperties();

    }
}
