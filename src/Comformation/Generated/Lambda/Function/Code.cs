using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Lambda.Function
{
    /// <summary>
    /// AWS Lambda Function Code
    /// Code is a property of the AWS::Lambda::Function resource that enables you to specify the source code of an AWS
    /// Lambda function. Your source code can be located in either the template or a file in an Amazon Simple Storage
    /// Service (Amazon S3) bucket. For nodejs4. 3, nodejs6. 10, python2. 7, and python3. 6 runtime environments only,
    /// you can provide source code as inline text in your template.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-function-code.html
    /// </summary>
    public class Code
    {

        /// <summary>
        /// S3Bucket
        /// The name of the Amazon S3 bucket where the . zip file that contains your deployment package is
        /// stored. This bucket must reside in the same AWS Region that you&#39;re creating the Lambda function in.
        /// You can specify a bucket from another AWS account as long as the Lambda function and the bucket are
        /// in the same region.
        /// Note The cfn-response module isn&#39;t available for source code that&#39;s stored in Amazon S3 buckets. To
        /// send responses, write your own functions.
        /// Required: Conditional Specify both the S3Bucket and S3Key properties, or specify the ZipFile
        /// property.
        /// Type: String
        /// </summary>
        [JsonProperty("S3Bucket")]
        public Union<string, IntrinsicFunction> S3Bucket { get; set; }

        /// <summary>
        /// S3Key
        /// The location and name of the . zip file that contains your source code. If you specify this
        /// property, you must also specify the S3Bucket property.
        /// Required: Conditional You must specify both the S3Bucket and S3Key properties, or specify the
        /// ZipFile property.
        /// Type: String
        /// </summary>
        [JsonProperty("S3Key")]
        public Union<string, IntrinsicFunction> S3Key { get; set; }

        /// <summary>
        /// S3ObjectVersion
        /// If you have S3 versioning enabled, the version ID of the. zip file that contains your source code.
        /// You can specify this property only if you specify the S3Bucket and S3Key properties.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("S3ObjectVersion")]
        public Union<string, IntrinsicFunction> S3ObjectVersion { get; set; }

        /// <summary>
        /// ZipFile
        /// For nodejs4. 3, nodejs6. 10, python2. 7, and python3. 6 runtime environments, the source code of
        /// your Lambda function. You can&#39;t use this property with other runtime environments.
        /// You can specify up to 4096 characters. You must precede certain special characters in your source
        /// code (such as quotation marks (&quot;), newlines (\n), and tabs (\t)) with a backslash (\). For a list of
        /// special characters, see http://json. org/.
        /// If you specify a function that interacts with an AWS CloudFormation custom resource, you don&#39;t have
        /// to write your own functions to send responses to the custom resource that invoked the function. AWS
        /// CloudFormation provides a response module that simplifies sending responses. For more information,
        /// see cfn-response Module.
        /// Required: Conditional You must specify both the S3Bucket and S3Key properties, or specify the
        /// ZipFile property.
        /// Type: String
        /// </summary>
        [JsonProperty("ZipFile")]
        public Union<string, IntrinsicFunction> ZipFile { get; set; }

    }
}
