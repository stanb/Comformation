using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Lambda.Function
{
    /// <summary>
    /// AWS::Lambda::Function
    /// The AWS::Lambda::Function resource creates an AWS Lambda (Lambda) function that can run code in response to
    /// events. To create a function, you need a deployment package and an execution role. For more information, see
    /// CreateFunction in the AWS Lambda Developer Guide.
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
            /// Type: AWS Lambda Function Code
            /// Update requires: No interruption
            /// </summary>
			public Code Code { get; set; }

            /// <summary>
            /// DeadLetterConfig
            /// A dead letter queue configuration that specifies the queue or topic where Lambda sends asynchronous
            /// events when they fail processing. For more information, see Dead Letter Queues.
            /// Required: No
            /// Type: AWS Lambda Function DeadLetterConfig
            /// Update requires: No interruption
            /// </summary>
			public DeadLetterConfig DeadLetterConfig { get; set; }

            /// <summary>
            /// Description
            /// A description of the function.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Environment
            /// Environment variables that are accessible from function code during execution.
            /// Required: No
            /// Type: AWS Lambda Function Environment
            /// Update requires: No interruption
            /// </summary>
			public Environment Environment { get; set; }

            /// <summary>
            /// FunctionName
            /// The name of the Lambda function. If you don&#39;t specify a name, AWS CloudFormation generates one. For
            /// more information, see Name Type.
            /// Important If you specify a name, you cannot perform updates that require replacement of this
            /// resource. You can perform updates that require no or some interruption. If you must replace the
            /// resource, specify a new name.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> FunctionName { get; set; }

            /// <summary>
            /// Handler
            /// The name of the method within your code that Lambda calls to execute your function. The format
            /// includes the filename and can also include namespaces and other qualifiers, depending on the
            /// runtime. For more information, see Programming Model.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Handler { get; set; }

            /// <summary>
            /// KmsKeyArn
            /// The Amazon Resource Name (ARN) of the AWS Key Management Service key used to encrypt your function&#39;s
            /// environment variables. If not provided, Lambda uses a default service key.
            /// Type: String
            /// Required: No
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> KmsKeyArn { get; set; }

            /// <summary>
            /// Layers
            /// A list of function layers to add to the function&#39;s execution environment. Specify each layer by ARN,
            /// including the version.
            /// Required: No
            /// Type: List of String values
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> Layers { get; set; }

            /// <summary>
            /// MemorySize
            /// The amount of memory that your function has access to. Increasing the function&#39;s memory also
            /// increases it&#39;s CPU allocation. The default value is 128 MB. The value must be a multiple of 64 MB.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> MemorySize { get; set; }

            /// <summary>
            /// ReservedConcurrentExecutions
            /// The maximum number of instances of your function that process events simultaneously. This option
            /// both sets the maximum concurrency for your function and reserves concurrency to ensure that it is
            /// available. For more information, see Managing Concurrency in the AWS Lambda Developer Guide.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> ReservedConcurrentExecutions { get; set; }

            /// <summary>
            /// Role
            /// The ARN of the function&#39;s execution role.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Role { get; set; }

            /// <summary>
            /// Runtime
            /// The identifier of the function&#39;s runtime.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Runtime { get; set; }

            /// <summary>
            /// Tags
            /// A list of tags to apply to the function.
            /// Required: No
            /// Type: Resource Tag
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

            /// <summary>
            /// Timeout
            /// The amount of time that Lambda allows a function to run before terminating it. The default is 3
            /// seconds. The maximum allowed value is 900 seconds.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> Timeout { get; set; }

            /// <summary>
            /// TracingConfig
            /// Set Mode to Active to sample and trace a subset of incoming requests with AWS X-Ray.
            /// Required: No
            /// Type: AWS Lambda Function TracingConfig
            /// Update requires: No interruption
            /// </summary>
			public TracingConfig TracingConfig { get; set; }

            /// <summary>
            /// VpcConfig
            /// For network connectivity to AWS resources in a VPC, specify a list of security groups and subnets in
            /// the VPC. When you connect a function to a VPC, it can only access resources and the internet through
            /// that VPC. For more information, see VPC Settings.
            /// Note When you specify this property, AWS CloudFormation might not be able to delete the stack if
            /// another resource in the template (such as a security group) requires the attached ENI to be deleted
            /// before it can be deleted. We recommend that you run AWS CloudFormation with the
            /// ec2:DescribeNetworkInterfaces permission, which enables AWS CloudFormation to monitor the state of
            /// the ENI and to wait (up to 40 minutes) for Lambda to delete the ENI.
            /// Required: No
            /// Type: AWS Lambda Function VpcConfig
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
