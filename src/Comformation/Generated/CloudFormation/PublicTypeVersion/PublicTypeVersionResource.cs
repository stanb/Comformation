using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFormation.PublicTypeVersion
{
    /// <summary>
    /// AWS::CloudFormation::PublicTypeVersion
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-publictypeversion.html
    /// </summary>
    public class PublicTypeVersionResource : ResourceBase
    {
        public class PublicTypeVersionProperties
        {
            /// <summary>
            /// Arn
            /// The Amazon Resource Number (ARN) of the extension.
            /// Conditional: You must specify Arn, or TypeName and Type.
            /// Required: Conditional
            /// Type: String
            /// Maximum: 1024
            /// Pattern: arn:aws[A-Za-z0-9-]{0,64}:cloudformation:[A-Za-z0-9-]{1,64}:([0-9]{12})?:type/. +
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Arn { get; set; }

            /// <summary>
            /// PublicVersionNumber
            /// The version number to assign to this version of the extension.
            /// Use the following format, and adhere to semantic versioning when assigning a version number to your
            /// extension:
            /// MAJOR. MINOR. PATCH
            /// For more information, see Semantic Versioning 2. 0. 0.
            /// If you do not specify a version number, CloudFormation increments the version number by one minor
            /// version release.
            /// The first time you publish a type, AWS CloudFormation sets the version number to 1. 0. 0, regardless
            /// of the value you specify.
            /// Required: No
            /// Type: String
            /// Minimum: 5
            /// Pattern: ^(0|[1-9]\d*)\. (0|[1-9]\d*)\. (. *)$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> PublicVersionNumber { get; set; }

            /// <summary>
            /// TypeName
            /// The name of the extension to test.
            /// Conditional: You must specify Arn, or TypeName and Type.
            /// Required: Conditional
            /// Type: String
            /// Minimum: 10
            /// Maximum: 204
            /// Pattern: [A-Za-z0-9]{2,64}::[A-Za-z0-9]{2,64}::[A-Za-z0-9]{2,64}(::MODULE){0,1}
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> TypeName { get; set; }

            /// <summary>
            /// LogDeliveryBucket
            /// The S3 bucket to which CloudFormation delivers the contract test execution logs.
            /// CloudFormation delivers the logs by the time contract testing has completed and the extension has
            /// been assigned a test type status of PASSED or FAILED.
            /// The user initiating the stack operation must be able to access items in the specified S3 bucket.
            /// Specifically, the user needs the following permissions:
            /// GetObject PutObject
            /// For more information, see Actions, Resources, and Condition Keys for Amazon S3 in the AWS Identity
            /// and Access Management User Guide.
            /// Required: No
            /// Type: String
            /// Minimum: 3
            /// Maximum: 63
            /// Pattern: [\s\S]+
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> LogDeliveryBucket { get; set; }

            /// <summary>
            /// Type
            /// The type of the extension to test.
            /// Conditional: You must specify Arn, or TypeName and Type.
            /// Required: Conditional
            /// Type: String
            /// Allowed values: MODULE | RESOURCE
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Type { get; set; }

        }

        public string Type { get; } = "AWS::CloudFormation::PublicTypeVersion";

        public PublicTypeVersionProperties Properties { get; } = new PublicTypeVersionProperties();

    }

    public static class PublicTypeVersionAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> TypeVersionArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("TypeVersionArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> PublisherId = new ResourceAttribute<Union<string, IntrinsicFunction>>("PublisherId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> PublicTypeArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("PublicTypeArn");
    }
}
