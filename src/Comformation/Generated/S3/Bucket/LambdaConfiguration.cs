using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// Amazon Simple Storage Service Bucket LambdaConfiguration
    /// LambdaConfigurations is a property of the Amazon S3 Bucket NotificationConfiguration property that describes
    /// the AWS Lambda (Lambda) functions to invoke and the events for which to invoke them.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-notificationconfig-lambdaconfig.html
    /// </summary>
    public class LambdaConfiguration
    {

        /// <summary>
        /// Event
        /// The S3 bucket event for which to invoke the Lambda function. For more information, see Supported
        /// Event Types in the Amazon Simple Storage Service Developer Guide.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Event")]
        public Union<string, IntrinsicFunction> Event { get; set; }

        /// <summary>
        /// Filter
        /// The filtering rules that determine which objects invoke the Lambda function. For example, you can
        /// create a filter so that only image files with a . jpg extension invoke the function when they are
        /// added to the S3 bucket.
        /// Required: No
        /// Type: Amazon S3 Bucket NotificationFilter
        /// </summary>
        [JsonProperty("Filter")]
        public Union<NotificationFilter, IntrinsicFunction> Filter { get; set; }

        /// <summary>
        /// Function
        /// The Amazon Resource Name (ARN) of the Lambda function that Amazon S3 invokes when the specified
        /// event type occurs.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Function")]
        public Union<string, IntrinsicFunction> Function { get; set; }

    }
}
