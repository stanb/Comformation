using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.LookoutEquipment.InferenceScheduler
{
    /// <summary>
    /// AWS::LookoutEquipment::InferenceScheduler
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lookoutequipment-inferencescheduler.html
    /// </summary>
    public class InferenceSchedulerResource : ResourceBase
    {
        public class InferenceSchedulerProperties
        {
            /// <summary>
            /// DataDelayOffsetInMinutes
            /// A period of time (in minutes) by which inference on the data is delayed after the data starts. For
            /// instance, if an offset delay time of five minutes was selected, inference will not begin on the data
            /// until the first data measurement after the five minute mark. For example, if five minutes is
            /// selected, the inference scheduler will wake up at the configured frequency with the additional five
            /// minute delay time to check the customer S3 bucket. The customer can upload data at the same
            /// frequency and they don&#39;t need to stop and restart the scheduler when uploading new data.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> DataDelayOffsetInMinutes { get; set; }

            /// <summary>
            /// DataInputConfiguration
            /// Specifies configuration information for the input data for the inference scheduler, including
            /// delimiter, format, and dataset location.
            /// Required: Yes
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> DataInputConfiguration { get; set; }

            /// <summary>
            /// DataOutputConfiguration
            /// Specifies configuration information for the output results for the inference scheduler, including
            /// the Amazon S3 location for the output.
            /// Required: Yes
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> DataOutputConfiguration { get; set; }

            /// <summary>
            /// DataUploadFrequency
            /// How often data is uploaded to the source S3 bucket for the input data. This value is the length of
            /// time between data uploads. For instance, if you select 5 minutes, Amazon Lookout for Equipment will
            /// upload the real-time data to the source bucket once every 5 minutes. This frequency also determines
            /// how often Amazon Lookout for Equipment starts a scheduled inference on your data. In this example,
            /// it starts once every 5 minutes.
            /// Required: Yes
            /// Type: String
            /// Allowed values: PT10M | PT15M | PT1H | PT30M | PT5M
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> DataUploadFrequency { get; set; }

            /// <summary>
            /// InferenceSchedulerName
            /// The name of the inference scheduler.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 200
            /// Pattern: ^[0-9a-zA-Z_-]{1,200}$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> InferenceSchedulerName { get; set; }

            /// <summary>
            /// ModelName
            /// The name of the ML model used for the inference scheduler.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 200
            /// Pattern: ^[0-9a-zA-Z_-]{1,200}$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ModelName { get; set; }

            /// <summary>
            /// RoleArn
            /// The Amazon Resource Name (ARN) of a role with permission to access the data source being used for
            /// the inference.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> RoleArn { get; set; }

            /// <summary>
            /// ServerSideKmsKeyId
            /// Provides the identifier of the AWS KMS key used to encrypt inference scheduler data by Amazon
            /// Lookout for Equipment.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ServerSideKmsKeyId { get; set; }

            /// <summary>
            /// Tags
            /// Any tags associated with the inference scheduler.
            /// For more information, see Tag.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::LookoutEquipment::InferenceScheduler";

        public InferenceSchedulerProperties Properties { get; } = new InferenceSchedulerProperties();

    }

    public static class InferenceSchedulerAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> InferenceSchedulerArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("InferenceSchedulerArn");
    }
}
