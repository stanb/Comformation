using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Lambda.Function
{
    /// <summary>
    /// AWS::Lambda::Function
    /// The AWS::Lambda::Function resource creates an AWS Lambda (Lambda) function that can run code in response to
    /// events. For more information, see CreateFunction in the AWS Lambda Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-function.html
    /// </summary>
    public class FunctionResource : ResourceBase
    {
        public class FunctionProperties
        {
            /// <summary>
            /// Code
            /// The source code of your Lambda function. You can point to a file in an Amazon Simple Storage Service
            /// (Amazon S3) bucket or specify your source code as inline text.
            /// Required: Yes
            /// Type: AWS Lambda Function Code
            /// Update requires: No interruption
            /// </summary>
			public Code Code { get; set; }

            /// <summary>
            /// DeadLetterConfig
            /// Configures how Lambda handles events that it can&#39;t process. If you don&#39;t specify a Dead Letter Queue
            /// (DLQ) configuration, Lambda discards events after the maximum number of retries. For more
            /// information, see Dead Letter Queues in the AWS Lambda Developer Guide.
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
            /// Key-value pairs that Lambda caches and makes available for your Lambda functions. Use environment
            /// variables to apply configuration changes, such as test and production environment configurations,
            /// without changing your Lambda function source code.
            /// Required: No
            /// Type: AWS Lambda Function Environment
            /// Update requires: No interruption
            /// </summary>
			public Environment Environment { get; set; }

            /// <summary>
            /// FunctionName
            /// A name for the function. If you don&#39;t specify a name, AWS CloudFormation generates a unique physical
            /// ID and uses that ID for the function&#39;s name. For more information, see Name Type.
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
            /// The name of the function (within your source code) that Lambda calls to start running your code. For
            /// more information, see the Handler property in the AWS Lambda Developer Guide.
            /// Note If you specify your source code as inline text by specifying the ZipFile property within the
            /// Code property, specify index. function_name as the handler.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Handler { get; set; }

            /// <summary>
            /// KmsKeyArn
            /// The Amazon Resource Name (ARN) of an AWS Key Management Service (AWS KMS) key that Lambda uses to
            /// encrypt and decrypt environment variable values.
            /// Type: String
            /// Required: No
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> KmsKeyArn { get; set; }

            /// <summary>
            /// Layers
            /// A list of Amazon Resource Names (ARNs) for the function layers to add to the function&#39;s execution
            /// environment. You can configure your Lambda function to pull in additional code during
            /// intitialization in the form of layers. Layers are packages of libraries or other dependencies that
            /// can be used by multiple functions.
            /// Required: No
            /// Type: List of String values
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> Layers { get; set; }

            /// <summary>
            /// MemorySize
            /// The amount of memory, in MB, that is allocated to your Lambda function. Lambda uses this value to
            /// proportionally allocate the amount of CPU power. For more information, see Resource Model in the AWS
            /// Lambda Developer Guide.
            /// Your function use case determines your CPU and memory requirements. For example, a database
            /// operation might need less memory than an image processing function. You must specify a value that is
            /// greater than or equal to 128, and it must be a multiple of 64. You cannot specify a size larger than
            /// 3008. The default value is 128 MB.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> MemorySize { get; set; }

            /// <summary>
            /// ReservedConcurrentExecutions
            /// The maximum of concurrent executions you want reserved for the function. For more information on
            /// reserved concurrency limits, see Managing Concurrency in the AWS Lambda Developer Guide.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> ReservedConcurrentExecutions { get; set; }

            /// <summary>
            /// Role
            /// The Amazon Resource Name (ARN) of the AWS Identity and Access Management (IAM) execution role that
            /// Lambda assumes when it runs your code to access AWS services.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Role { get; set; }

            /// <summary>
            /// Runtime
            /// The runtime environment for the Lambda function that you are uploading. For valid values, see the
            /// Runtime property in the AWS Lambda Developer Guide.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// Note Because Node. js 0. 10. 32 has been deprecated, you can no longer roll back a template that
            /// uses Node. js 0. 10. 32. If you update a stack to Node. js 0. 10. 32 and the update fails, AWS
            /// CloudFormation won&#39;t roll it back.
            /// </summary>
			public Union<string, IntrinsicFunction> Runtime { get; set; }

            /// <summary>
            /// Tags
            /// An arbitrary set of tags (key–value pairs) for this Lambda function.
            /// Required: No
            /// Type: Resource Tag
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

            /// <summary>
            /// Timeout
            /// The function execution time (in seconds) after which Lambda terminates the function. Because the
            /// execution time affects cost, set this value based on the function&#39;s expected execution time. By
            /// default, Timeout is set to 3 seconds. For more information, see the FAQs.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> Timeout { get; set; }

            /// <summary>
            /// TracingConfig
            /// The parent object that contains your Lambda function&#39;s tracing settings. By default, the Mode
            /// property is set to PassThrough. For valid values, see the TracingConfig data type in the AWS Lambda
            /// Developer Guide.
            /// Required: No
            /// Type: AWS Lambda Function TracingConfig
            /// Update requires: No interruption
            /// </summary>
			public TracingConfig TracingConfig { get; set; }

            /// <summary>
            /// VpcConfig
            /// If the Lambda function requires access to resources in a VPC, specify a VPC configuration that
            /// Lambda uses to set up an elastic network interface (ENI). The ENI enables your function to connect
            /// to other resources in your VPC, but it doesn&#39;t provide public Internet access. If your function
            /// requires Internet access (for example, to access AWS services that don&#39;t have VPC endpoints),
            /// configure a Network Address Translation (NAT) instance inside your VPC or use an Amazon Virtual
            /// Private Cloud (Amazon VPC) NAT gateway. For more information, see NAT Gateways in the Amazon VPC
            /// User Guide.
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
