using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Lambda.Function
{
    /// <summary>
    /// AWS Lambda Function Code
    /// Code is a property of the AWS::Lambda::Function resource that specifies the code for a Lambda function. For
    /// all runtimes, you can specify the location of a deployment package in Amazon S3. For Node. js and Python
    /// functions, you can also specify the function code inline in the template.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-function-code.html
    /// </summary>
    public class Code
    {

        /// <summary>
        /// S3Bucket
        /// An Amazon S3 bucket in the same region as your function. The bucket can be in a different AWS
        /// account.
        /// Note The cfn-response module isn&#39;t available for source code that&#39;s stored in Amazon S3 buckets. To
        /// send responses, write your own functions.
        /// Required: Conditional. Specify both the S3Bucket and S3Key properties, or specify the ZipFile
        /// property.
        /// Type: String
        /// </summary>
        [JsonProperty("S3Bucket")]
        public Union<string, IntrinsicFunction> S3Bucket { get; set; }

        /// <summary>
        /// S3Key
        /// The Amazon S3 key of the deployment package.
        /// Required: Conditional. You must specify both the S3Bucket and S3Key properties, or specify the
        /// ZipFile property.
        /// Type: String
        /// </summary>
        [JsonProperty("S3Key")]
        public Union<string, IntrinsicFunction> S3Key { get; set; }

        /// <summary>
        /// S3ObjectVersion
        /// For versioned objects, the version of the deployment package object to use.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("S3ObjectVersion")]
        public Union<string, IntrinsicFunction> S3ObjectVersion { get; set; }

        /// <summary>
        /// ZipFile
        /// (Node. js and Python) The source code of your Lambda function. If you include your function source
        /// inline with this parameter, AWS CloudFormation places it in a file named index and zips it to create
        /// a deployment package. For the Handler property, the first part of the handler identifier must be
        /// index. For example, index. handler.
        /// Your source code can contain up to 4096 characters. For JSON, you must escape quotes and special
        /// characters such as newline (\n) with a backslash.
        /// If you specify a function that interacts with an AWS CloudFormation custom resource, you don&#39;t have
        /// to write your own functions to send responses to the custom resource that invoked the function. AWS
        /// CloudFormation provides a response module that simplifies sending responses. For more information,
        /// see cfn-response Module.
        /// Required: Conditional. You must specify both the S3Bucket and S3Key properties, or specify the
        /// ZipFile property.
        /// Type: String
        /// </summary>
        [JsonProperty("ZipFile")]
        public Union<string, IntrinsicFunction> ZipFile { get; set; }

    }
}
