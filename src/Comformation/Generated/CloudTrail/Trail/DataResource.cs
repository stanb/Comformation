using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudTrail.Trail
{
    /// <summary>
    /// AWS::CloudTrail::Trail DataResource
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudtrail-trail-dataresource.html
    /// </summary>
    public class DataResource
    {

        /// <summary>
        /// Type
        /// The resource type in which you want to log data events. You can specify AWS::S3::Object,
        /// AWS::Lambda::Function, or AWS::DynamoDB::Table resources.
        /// The AWS::S3Outposts::Object, AWS::ManagedBlockchain::Node, AWS::S3ObjectLambda::AccessPoint, and
        /// AWS::EC2::Snapshot resource types are not valid in basic event selectors. To log data events on
        /// these resource types, use advanced event selectors.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// Values
        /// An array of Amazon Resource Name (ARN) strings or partial ARN strings for the specified objects.
        /// To log data events for all objects in all S3 buckets in your AWS account, specify the prefix as
        /// arn:aws:s3:::. Note This also enables logging of data event activity performed by any user or role
        /// in your AWS account, even if that activity is performed on a bucket that belongs to another AWS
        /// account. To log data events for all objects in an S3 bucket, specify the bucket and an empty object
        /// prefix such as arn:aws:s3:::bucket-1/. The trail logs data events for all objects in this S3 bucket.
        /// To log data events for specific objects, specify the S3 bucket and object prefix such as
        /// arn:aws:s3:::bucket-1/example-images. The trail logs data events for objects in this S3 bucket that
        /// match the prefix. To log data events for all Lambda functions in your AWS account, specify the
        /// prefix as arn:aws:lambda. Note This also enables logging of Invoke activity performed by any user or
        /// role in your AWS account, even if that activity is performed on a function that belongs to another
        /// AWS account. To log data events for a specific Lambda function, specify the function ARN. Note
        /// Lambda function ARNs are exact. For example, if you specify a function ARN
        /// arn:aws:lambda:us-west-2:111111111111:function:helloworld, data events will only be logged for
        /// arn:aws:lambda:us-west-2:111111111111:function:helloworld. They will not be logged for
        /// arn:aws:lambda:us-west-2:111111111111:function:helloworld2. To log data events for all DynamoDB
        /// tables in your AWS account, specify the prefix as arn:aws:dynamodb.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Values")]
        public List<Union<string, IntrinsicFunction>> Values { get; set; }

    }
}
