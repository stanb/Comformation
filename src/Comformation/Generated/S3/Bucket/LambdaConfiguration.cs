using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// AWS::S3::Bucket LambdaConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-notificationconfig-lambdaconfig.html
    /// </summary>
    public class LambdaConfiguration
    {

        /// <summary>
        /// Event
        /// The Amazon S3 bucket event for which to invoke the AWS Lambda function. For more information, see
        /// Supported Event Types in the Amazon S3 User Guide.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Event")]
        public Union<string, IntrinsicFunction> Event { get; set; }

        /// <summary>
        /// Filter
        /// The filtering rules that determine which objects invoke the AWS Lambda function. For example, you
        /// can create a filter so that only image files with a . jpg extension invoke the function when they
        /// are added to the Amazon S3 bucket.
        /// Required: No
        /// Type: NotificationFilter
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Filter")]
        public NotificationFilter Filter { get; set; }

        /// <summary>
        /// Function
        /// The Amazon Resource Name (ARN) of the AWS Lambda function that Amazon S3 invokes when the specified
        /// event type occurs.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Function")]
        public Union<string, IntrinsicFunction> Function { get; set; }

    }
}
