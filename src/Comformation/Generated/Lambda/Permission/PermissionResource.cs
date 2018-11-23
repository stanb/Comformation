using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Lambda.Permission
{
    /// <summary>
    /// AWS::Lambda::Permission
    /// The AWS::Lambda::Permission resource associates a policy statement with a specific AWS Lambda (Lambda)
    /// function&#39;s access policy. The function policy grants a specific AWS service or application permission to
    /// invoke the function. For more information, see AddPermission in the AWS Lambda Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-permission.html
    /// </summary>
    public class PermissionResource : ResourceBase
    {
        public class PermissionProperties
        {
            /// <summary>
            /// Action
            /// The Lambda actions that you want to allow in this statement. For example, you can specify
            /// lambda:CreateFunction to specify a certain action, or use a wildcard (lambda:*) to grant permission
            /// to all Lambda actions. For a list of actions, see Actions and Condition Context Keys for AWS Lambda
            /// in the IAM User Guide.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Action { get; set; }

            /// <summary>
            /// EventSourceToken
            /// A unique token that must be supplied by the principal invoking the function.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> EventSourceToken { get; set; }

            /// <summary>
            /// FunctionName
            /// The name (physical ID), Amazon Resource Name (ARN), or alias ARN of the Lambda function that you
            /// want to associate with this statement. Lambda adds this statement to the function&#39;s access policy.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> FunctionName { get; set; }

            /// <summary>
            /// Principal
            /// The entity for which you are granting permission to invoke the Lambda function. This entity can be
            /// any valid AWS service principal, such as s3. amazonaws. com or sns. amazonaws. com, or, if you are
            /// granting cross-account permission, an AWS account ID. For example, you might want to allow a custom
            /// application in another AWS account to push events to Lambda by invoking your function.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Principal { get; set; }

            /// <summary>
            /// SourceAccount
            /// The AWS account ID (without hyphens) of the source owner. For example, if you specify an S3 bucket
            /// in the SourceArn property, this value is the bucket owner&#39;s account ID. You can use this property to
            /// ensure that all source principals are owned by a specific account.
            /// Important This property is not supported by all event sources. For more information, see the
            /// SourceAccount parameter for the AddPermission action in the AWS Lambda Developer Guide.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> SourceAccount { get; set; }

            /// <summary>
            /// SourceArn
            /// The ARN of a resource that is invoking your function. When granting Amazon Simple Storage Service
            /// (Amazon S3) permission to invoke your function, specify this property with the bucket ARN as its
            /// value. This ensures that events generated only from the specified bucket, not just any bucket from
            /// any AWS account that creates a mapping to your function, can invoke the function.
            /// Important This property is not supported by all event sources. For more information, see the
            /// SourceArn parameter for the AddPermission action in the AWS Lambda Developer Guide.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> SourceArn { get; set; }

        }

        public string Type { get; } = "AWS::Lambda::Permission";

        public PermissionProperties Properties { get; } = new PermissionProperties();

    }
}
