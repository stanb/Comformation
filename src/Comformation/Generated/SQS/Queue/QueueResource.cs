using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SQS.Queue
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sqs-queues.html
    /// </summary>
    public class QueueResource : ResourceBase
    {
        public class QueueProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sqs-queues.html#aws-sqs-queue-contentbaseddeduplication
            /// </summary>
			public Union<bool?, IntrinsicFunction> ContentBasedDeduplication { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sqs-queues.html#aws-sqs-queue-delayseconds
            /// </summary>
			public Union<int?, IntrinsicFunction> DelaySeconds { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sqs-queues.html#aws-sqs-queue-fifoqueue
            /// </summary>
			public Union<bool?, IntrinsicFunction> FifoQueue { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sqs-queues.html#aws-sqs-queue-kmsdatakeyreuseperiodseconds
            /// </summary>
			public Union<int?, IntrinsicFunction> KmsDataKeyReusePeriodSeconds { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sqs-queues.html#aws-sqs-queue-kmsmasterkeyid
            /// </summary>
			public Union<string, IntrinsicFunction> KmsMasterKeyId { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sqs-queues.html#aws-sqs-queue-maxmesgsize
            /// </summary>
			public Union<int?, IntrinsicFunction> MaximumMessageSize { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sqs-queues.html#aws-sqs-queue-msgretentionperiod
            /// </summary>
			public Union<int?, IntrinsicFunction> MessageRetentionPeriod { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sqs-queues.html#aws-sqs-queue-name
            /// </summary>
			public Union<string, IntrinsicFunction> QueueName { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sqs-queues.html#aws-sqs-queue-receivemsgwaittime
            /// </summary>
			public Union<int?, IntrinsicFunction> ReceiveMessageWaitTimeSeconds { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sqs-queues.html#aws-sqs-queue-redrive
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> RedrivePolicy { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sqs-queues.html#aws-sqs-queue-visiblitytimeout
            /// </summary>
			public Union<int?, IntrinsicFunction> VisibilityTimeout { get; set; }

        }
    
        public string Type { get; } = "AWS::SQS::Queue";
        
        public QueueProperties Properties { get; } = new QueueProperties();
    }

	public static class QueueAttributes
	{
        public static readonly ResourceAttribute<string> Arn = new ResourceAttribute<string>("Arn");
        public static readonly ResourceAttribute<string> QueueName = new ResourceAttribute<string>("QueueName");
	}
}
