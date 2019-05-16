using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Lambda.Function
{
    /// <summary>
    /// AWS::Lambda::Function
    /// The AWS::Lambda::Function resource creates a Lambda function. To create a function, you need a deployment
    /// package and an execution role. The deployment package contains your function code. The execution role grants
    /// the function permission to use AWS services, such as Amazon CloudWatch Logs for log streaming and AWS X-Ray
    /// for request tracing.
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
            /// FunctionName
            /// The name of the Lambda function, up to 64 characters in length. If you don&#39;t specify a name, AWS
            /// CloudFormation generates one.
            /// If you specify a name, you cannot perform updates that require replacement of this resource. You can
            /// perform updates that require no or some interruption. If you must replace the resource, specify a
            /// new name.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 140
            /// Pattern:
            /// (arn:(aws[a-zA-Z-]*)?:lambda:)?([a-z]{2}(-gov)?-[a-z]+-\d{1}:)?(\d{12}:)?(function:)?([a-zA-Z0-9-_]+)(:(\$LATEST|[a-zA-Z0-9-_]+))?
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> FunctionName { get; set; }

            /// <summary>
            /// Handler
            /// The name of the method within your code that Lambda calls to execute your function. The format
            /// includes the file name. It can also include namespaces and other qualifiers, depending on the
            /// runtime. For more information, see Programming Model.
            /// Required: Yes
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
            /// The amount of memory that your function has access to. Increasing the function&#39;s memory also
            /// increases its CPU allocation. The default value is 128 MB. The value must be a multiple of 64 MB.
            /// Required: No
            /// Type: Integer
            /// Minimum: 128
            /// Maximum: 3008
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
            /// Required: Yes
            /// Type: String
            /// Allowed Values: dotnetcore1. 0 | dotnetcore2. 1 | go1. x | java8 | nodejs10. x | nodejs8. 10 |
            /// provided | python2. 7 | python3. 6 | python3. 7 | ruby2. 5
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
            /// seconds. The maximum allowed value is 900 seconds.
            /// Required: No
            /// Type: Integer
            /// Minimum: 1
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> Timeout { get; set; }

            /// <summary>
            /// TracingConfig
            /// Set Mode to Active to sample and trace a subset of incoming requests with AWS X-Ray.
            /// Required: No
            /// Type: TracingConfig
            /// Update requires: No interruption
            /// </summary>
			public TracingConfig TracingConfig { get; set; }

            /// <summary>
            /// VpcConfig
            /// For network connectivity to AWS resources in a VPC, specify a list of security groups and subnets in
            /// the VPC. When you connect a function to a VPC, it can only access resources and the internet through
            /// that VPC. For more information, see VPC Settings.
            /// Required: No
            /// Type: VpcConfig
            /// Update requires: No interruption
            /// </summary>
			public VpcConfig VpcConfig { get; set; }

        }

        public string Type { get; } = "AWS::Lambda::Function";

        public FunctionProperties Properties { get; } = new FunctionProperties();

    }

	public static class FunctionAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
	}
}
