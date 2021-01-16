using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaConvert.Queue
{
    /// <summary>
    /// AWS::MediaConvert::Queue
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconvert-queue.html
    /// </summary>
    public class QueueResource : ResourceBase
    {
        public class QueueProperties
        {
            /// <summary>
            /// Status
            /// Initial state of the queue. Queues can be either ACTIVE or PAUSED. If you create a paused queue,
            /// then jobs that you send to that queue won&#39;t begin.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Status { get; set; }

            /// <summary>
            /// Description
            /// Optional. A description of the queue that you are creating.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// PricingPlan
            /// When you use AWS CloudFormation, you can create only on-demand queues. Therefore, always set
            /// PricingPlan to the value &quot;ON_DEMAND&quot; when declaring an AWS::MediaConvert::Queue in your AWS
            /// CloudFormation template.
            /// To create a reserved queue, use the AWS Elemental MediaConvert console at https://console. aws.
            /// amazon. com/mediaconvert to set up a contract. For more information, see Working with AWS Elemental
            /// MediaConvert Queues in the AWS Elemental MediaConvert User Guide.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> PricingPlan { get; set; }

            /// <summary>
            /// Tags
            /// An array of key-value pairs to apply to this resource.
            /// For more information, see Tag.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Tags { get; set; }

            /// <summary>
            /// Name
            /// The name of the queue that you are creating.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::MediaConvert::Queue";

        public QueueProperties Properties { get; } = new QueueProperties();

    }

    public static class QueueAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Name = new ResourceAttribute<Union<string, IntrinsicFunction>>("Name");
    }
}
