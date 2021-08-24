using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Lambda.Function
{
    /// <summary>
    /// AWS::Lambda::Function
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-function.html
    /// </summary>
    public class FunctionResource : ResourceBase
    {
        public class FunctionProperties
        {
            /// <summary>
            /// Code
            /// The code for the function.
            /// Required: Yes
            /// Type: Code
            /// Update requires: No interruption
            /// </summary>
            public Code Code { get; set; }

            /// <summary>
            /// DeadLetterConfig
            /// A dead letter queue configuration that specifies the queue or topic where Lambda sends asynchronous
            /// events when they fail processing. For more information, see Dead Letter Queues.
            /// Required: No
            /// Type: DeadLetterConfig
            /// Update requires: No interruption
            /// </summary>
            public DeadLetterConfig DeadLetterConfig { get; set; }

            /// <summary>
            /// Description
            /// A description of the function.
            /// Required: No
            /// Type: String
            /// Minimum: 0
            /// Maximum: 256
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Environment
            /// Environment variables that are accessible from function code during execution.
            /// Required: No
            /// Type: Environment
            /// Update requires: No interruption
            /// </summary>
            public Environment Environment { get; set; }

            /// <summary>
            /// FileSystemConfigs
            /// Connection settings for an Amazon EFS file system. To connect a function to a file system, a mount
            /// target must be available in every Availability Zone that your function connects to. If your template
            /// contains an AWS::EFS::MountTarget resource, you must also specify a DependsOn attribute to ensure
            /// that the mount target is created or updated before the function.
            /// For more information about using the DependsOn attribute, see DependsOn Attribute.
            /// Required: No
            /// Type: List of FileSystemConfig
            /// Maximum: 1
            /// Update requires: No interruption
            /// </summary>
            public List<FileSystemConfig> FileSystemConfigs { get; set; }

            /// <summary>
            /// FunctionName
            /// The name of the Lambda function, up to 64 characters in length. If you don&#39;t specify a name, AWS
            /// CloudFormation generates one.
            /// If you specify a name, you cannot perform updates that require replacement of this resource. You can
            /// perform updates that require no or some interruption. If you must replace the resource, specify a
            /// new name.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> FunctionName { get; set; }

            /// <summary>
            /// Handler
            /// The name of the method within your code that Lambda calls to execute your function. The format
            /// includes the file name. It can also include namespaces and other qualifiers, depending on the
            /// runtime. For more information, see Programming Model.
            /// Required: No
            /// Type: String
            /// Maximum: 128
            /// Pattern: [^\s]+
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Handler { get; set; }

            /// <summary>
            /// KmsKeyArn
            /// The ARN of the AWS Key Management Service (AWS KMS) key that&#39;s used to encrypt your function&#39;s
            /// environment variables. If it&#39;s not provided, AWS Lambda uses a default service key.
            /// Required: No
            /// Type: String
            /// Pattern: (arn:(aws[a-zA-Z-]*)?:[a-z0-9-. ]+:. *)|()
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> KmsKeyArn { get; set; }

            /// <summary>
            /// Layers
            /// A list of function layers to add to the function&#39;s execution environment. Specify each layer by its
            /// ARN, including the version.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> Layers { get; set; }

            /// <summary>
            /// MemorySize
            /// The amount of memory available to the function at runtime. Increasing the function memory also
            /// increases its CPU allocation. The default value is 128 MB. The value can be any multiple of 1 MB.
            /// Required: No
            /// Type: Integer
            /// Minimum: 128
            /// Maximum: 10240
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> MemorySize { get; set; }

            /// <summary>
            /// ReservedConcurrentExecutions
            /// The number of simultaneous executions to reserve for the function.
            /// Required: No
            /// Type: Integer
            /// Minimum: 0
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> ReservedConcurrentExecutions { get; set; }

            /// <summary>
            /// Role
            /// The Amazon Resource Name (ARN) of the function&#39;s execution role.
            /// Required: Yes
            /// Type: String
            /// Pattern: arn:(aws[a-zA-Z-]*)?:iam::\d{12}:role/?[a-zA-Z_0-9+=,. @\-_/]+
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Role { get; set; }

            /// <summary>
            /// Runtime
            /// The identifier of the function&#39;s runtime.
            /// Required: No
            /// Type: String
            /// Allowed values: dotnetcore1. 0 | dotnetcore2. 0 | dotnetcore2. 1 | dotnetcore3. 1 | go1. x | java11
            /// | java8 | java8. al2 | nodejs | nodejs10. x | nodejs12. x | nodejs14. x | nodejs4. 3 | nodejs4.
            /// 3-edge | nodejs6. 10 | nodejs8. 10 | provided | provided. al2 | python2. 7 | python3. 6 | python3. 7
            /// | python3. 8 | python3. 9 | ruby2. 5 | ruby2. 7
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Runtime { get; set; }

            /// <summary>
            /// Tags
            /// A list of tags to apply to the function.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// Timeout
            /// The amount of time that Lambda allows a function to run before stopping it. The default is 3
            /// seconds. The maximum allowed value is 900 seconds. For additional information, see Lambda execution
            /// environment.
            /// Required: No
            /// Type: Integer
            /// Minimum: 1
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> Timeout { get; set; }

            /// <summary>
            /// TracingConfig
            /// Set Mode to Active to sample and trace a subset of incoming requests with X-Ray.
            /// Required: No
            /// Type: TracingConfig
            /// Update requires: No interruption
            /// </summary>
            public TracingConfig TracingConfig { get; set; }

            /// <summary>
            /// VpcConfig
            /// For network connectivity to AWS resources in a VPC, specify a list of security groups and subnets in
            /// the VPC.
            /// Required: No
            /// Type: VpcConfig
            /// Update requires: No interruption
            /// </summary>
            public VpcConfig VpcConfig { get; set; }

            /// <summary>
            /// CodeSigningConfigArn
            /// To enable code signing for this function, specify the ARN of a code-signing configuration. A
            /// code-signing configuration includes a set of signing profiles, which define the trusted publishers
            /// for this function.
            /// Required: No
            /// Type: String
            /// Maximum: 200
            /// Pattern:
            /// arn:(aws[a-zA-Z-]*)?:lambda:[a-z]{2}((-gov)|(-iso(b?)))?-[a-z]+-\d{1}:\d{12}:code-signing-config:csc-[a-z0-9]{17}
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> CodeSigningConfigArn { get; set; }

            /// <summary>
            /// ImageConfig
            /// Configuration values that override the container image Dockerfile settings. See Container settings.
            /// Required: No
            /// Type: ImageConfig
            /// Update requires: No interruption
            /// </summary>
            public ImageConfig ImageConfig { get; set; }

            /// <summary>
            /// PackageType
            /// The type of deployment package. Set to Image for container image and set Zip for . zip file archive.
            /// Required: No
            /// Type: String
            /// Allowed values: Image | Zip
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> PackageType { get; set; }

        }

        public string Type { get; } = "AWS::Lambda::Function";

        public FunctionProperties Properties { get; } = new FunctionProperties();

    }

    public static class FunctionAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
