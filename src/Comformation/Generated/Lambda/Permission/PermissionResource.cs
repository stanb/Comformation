using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Lambda.Permission
{
    /// <summary>
    /// AWS::Lambda::Permission
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-permission.html
    /// </summary>
    public class PermissionResource : ResourceBase
    {
        public class PermissionProperties
        {
            /// <summary>
            /// Action
            /// The action that the principal can use on the function. For example, lambda:InvokeFunction or
            /// lambda:GetFunction.
            /// Required: Yes
            /// Type: String
            /// Pattern: (lambda:[*]|lambda:[a-zA-Z]+|[*])
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Action { get; set; }

            /// <summary>
            /// EventSourceToken
            /// For Alexa Smart Home functions, a token that must be supplied by the invoker.
            /// Required: No
            /// Type: String
            /// Minimum: 0
            /// Maximum: 256
            /// Pattern: [a-zA-Z0-9. _\-]+
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> EventSourceToken { get; set; }

            /// <summary>
            /// FunctionName
            /// The name of the Lambda function, version, or alias.
            /// Name formats Function name - my-function (name-only), my-function:v1 (with alias). Function ARN -
            /// arn:aws:lambda:us-west-2:123456789012:function:my-function. Partial ARN -
            /// 123456789012:function:my-function.
            /// You can append a version number or alias to any of the formats. The length constraint applies only
            /// to the full ARN. If you specify only the function name, it is limited to 64 characters in length.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 140
            /// Pattern:
            /// (arn:(aws[a-zA-Z-]*)?:lambda:)?([a-z]{2}(-gov)?-[a-z]+-\d{1}:)?(\d{12}:)?(function:)?([a-zA-Z0-9-_]+)(:(\$LATEST|[a-zA-Z0-9-_]+))?
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> FunctionName { get; set; }

            /// <summary>
            /// Principal
            /// The AWS service or account that invokes the function. If you specify a service, use SourceArn or
            /// SourceAccount to limit who can invoke the function through that service.
            /// Required: Yes
            /// Type: String
            /// Pattern: . *
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Principal { get; set; }

            /// <summary>
            /// SourceAccount
            /// For Amazon S3, the ID of the account that owns the resource. Use this together with SourceArn to
            /// ensure that the resource is owned by the specified account. It is possible for an Amazon S3 bucket
            /// to be deleted by its owner and recreated by another account.
            /// Required: No
            /// Type: String
            /// Pattern: \d{12}
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> SourceAccount { get; set; }

            /// <summary>
            /// SourceArn
            /// For AWS services, the ARN of the AWS resource that invokes the function. For example, an Amazon S3
            /// bucket or Amazon SNS topic.
            /// Required: No
            /// Type: String
            /// Pattern: arn:(aws[a-zA-Z0-9-]*):([a-zA-Z0-9\-])+:([a-z]{2}(-gov)?-[a-z]+-\d{1})?:(\d{12})?:(. *)
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> SourceArn { get; set; }

        }

        public string Type { get; } = "AWS::Lambda::Permission";

        public PermissionProperties Properties { get; } = new PermissionProperties();

    }
}
