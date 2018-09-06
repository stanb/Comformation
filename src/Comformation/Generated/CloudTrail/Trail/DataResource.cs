using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudTrail.Trail
{
    /// <summary>
    /// AWS CloudTrail Trail DataResource
    /// The DataResource property type specifies Amazon S3 objects for event selectors in a CloudTrail trail. Data
    /// events are object-level API operations that access Amazon S3 objects, such as GetObject, DeleteObject, and
    /// PutObject. You can specify up to 250 Amazon S3 buckets and object prefixes for a trail. For more information,
    /// see DataResource in the AWS CloudTrail API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudtrail-trail-dataresource.html
    /// </summary>
    public class DataResource
    {

        /// <summary>
        /// Type
        /// The resource type to log data events for. You can specify the following values: AWS::S3::Object or
        /// AWS::Lambda::Function.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// Values
        /// A list of ARN-like strings for the specified Amazon S3 objects.
        /// To log data events for all objects in all Amazon S3 buckets in your AWS account, specify the prefix
        /// as arn:aws:s3:::.
        /// To log data events for all objects in an Amazon S3 bucket, specify the bucket and an empty object
        /// prefix such as arn:aws:s3:::bucket-1/. The trail logs data events for all objects in this Amazon S3
        /// bucket.
        /// To log data events for specific objects, specify the Amazon S3 bucket and object prefix such as
        /// arn:aws:s3:::bucket-1/example-images. The trail logs data events for objects in the bucket that
        /// match the prefix.
        /// Required: No
        /// Type: List of String values
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Values")]
        public Union<List<string>, IntrinsicFunction> Values { get; set; }

    }
}
