using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Lambda.Function
{
    /// <summary>
    /// AWS::Lambda::Function Code
    /// The deployment package for a Lambda function. For all runtimes, you can specify the location of an object in
    /// Amazon S3. For Node. js and Python functions, you can specify the function code inline in the template.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-function-code.html
    /// </summary>
    public class Code
    {

        /// <summary>
        /// S3Bucket
        /// An Amazon S3 bucket in the same AWS Region as your function. The bucket can be in a different AWS
        /// account.
        /// Required: Conditional
        /// Type: String
        /// Minimum: 3
        /// Maximum: 63
        /// Pattern: ^[0-9A-Za-z\. \-_]*(?&amp;lt;!\. )$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3Bucket")]
        public Union<string, IntrinsicFunction> S3Bucket { get; set; }

        /// <summary>
        /// S3Key
        /// The Amazon S3 key of the deployment package.
        /// Required: Conditional
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1024
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3Key")]
        public Union<string, IntrinsicFunction> S3Key { get; set; }

        /// <summary>
        /// S3ObjectVersion
        /// For versioned objects, the version of the deployment package object to use.
        /// Required: Conditional
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1024
        /// Update requires: No interruption
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
        /// CloudFormation provides a response module (cfn-module) that simplifies sending responses.
        /// Required: Conditional
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ZipFile")]
        public Union<string, IntrinsicFunction> ZipFile { get; set; }

    }
}
