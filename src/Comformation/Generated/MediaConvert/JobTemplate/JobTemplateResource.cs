using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaConvert.JobTemplate
{
    /// <summary>
    /// AWS::MediaConvert::JobTemplate
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconvert-jobtemplate.html
    /// </summary>
    public class JobTemplateResource : ResourceBase
    {
        public class JobTemplateProperties
        {
            /// <summary>
            /// Category
            /// Optional. A category for the job template you are creating
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Category { get; set; }

            /// <summary>
            /// Description
            /// Optional. A description of the job template you are creating.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// AccelerationSettings
            /// Accelerated transcoding can significantly speed up jobs with long, visually complex content. Outputs
            /// that use this feature incur pro-tier pricing. For information about feature limitations, For more
            /// information, see Job Limitations for Accelerated Transcoding in AWS Elemental MediaConvert in the
            /// AWS Elemental MediaConvert User Guide.
            /// Required: No
            /// Type: AccelerationSettings
            /// Update requires: No interruption
            /// </summary>
            public AccelerationSettings AccelerationSettings { get; set; }

            /// <summary>
            /// Priority
            /// Specify the relative priority for this job. In any given queue, the service begins processing the
            /// job with the highest value first. When more than one job has the same priority, the service begins
            /// processing the job that you submitted first. If you don&#39;t specify a priority, the service uses the
            /// default value 0. Minimum: -50 Maximum: 50
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> Priority { get; set; }

            /// <summary>
            /// StatusUpdateInterval
            /// Specify how often MediaConvert sends STATUS_UPDATE events to Amazon CloudWatch Events. Set the
            /// interval, in seconds, between status updates. MediaConvert sends an update at this interval from the
            /// time the service begins processing your job to the time it completes the transcode or encounters an
            /// error.
            /// Specify one of the following enums:
            /// SECONDS_10
            /// SECONDS_12
            /// SECONDS_15
            /// SECONDS_20
            /// SECONDS_30
            /// SECONDS_60
            /// SECONDS_120
            /// SECONDS_180
            /// SECONDS_240
            /// SECONDS_300
            /// SECONDS_360
            /// SECONDS_420
            /// SECONDS_480
            /// SECONDS_540
            /// SECONDS_600
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> StatusUpdateInterval { get; set; }

            /// <summary>
            /// SettingsJson
            /// Specify, in JSON format, the transcoding job settings for this job template. This specification must
            /// conform to the AWS Elemental MediaConvert job validation. For information about forming this
            /// specification, see the Remarks section later in this topic.
            /// For more information about MediaConvert job templates, see Working with AWS Elemental MediaConvert
            /// Job Templates in the AWS Elemental MediaConvert User Guide.
            /// Required: Yes
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> SettingsJson { get; set; }

            /// <summary>
            /// Queue
            /// Optional. The queue that jobs created from this template are assigned to. Specify the Amazon
            /// Resource Name (ARN) of the queue. For example,
            /// arn:aws:mediaconvert:us-west-2:505474453218:queues/Default. If you don&#39;t specify this, jobs will go
            /// to the default queue.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Queue { get; set; }

            /// <summary>
            /// HopDestinations
            /// Optional. Configuration for a destination queue to which the job can hop once a customer-defined
            /// minimum wait time has passed. For more information, see Setting Up Queue Hopping to Avoid Long Waits
            /// in the AWS Elemental MediaConvert User Guide.
            /// Required: No
            /// Type: List of HopDestination
            /// Update requires: No interruption
            /// </summary>
            public List<HopDestination> HopDestinations { get; set; }

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
            /// The name of the job template you are creating.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::MediaConvert::JobTemplate";

        public JobTemplateProperties Properties { get; } = new JobTemplateProperties();

    }

    public static class JobTemplateAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Name = new ResourceAttribute<Union<string, IntrinsicFunction>>("Name");
    }
}
