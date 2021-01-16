using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.QLDB.Stream
{
    /// <summary>
    /// AWS::QLDB::Stream
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qldb-stream.html
    /// </summary>
    public class StreamResource : ResourceBase
    {
        public class StreamProperties
        {
            /// <summary>
            /// LedgerName
            /// The name of the ledger.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 32
            /// Pattern: (?!^. *--)(?!^[0-9]+$)(?!^-)(?!. *-$)^[A-Za-z0-9-]+$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> LedgerName { get; set; }

            /// <summary>
            /// StreamName
            /// The name that you want to assign to the QLDB journal stream. User-defined names can help identify
            /// and indicate the purpose of a stream.
            /// Your stream name must be unique among other active streams for a given ledger. Stream names have the
            /// same naming constraints as ledger names, as defined in Quotas in Amazon QLDB in the Amazon QLDB
            /// Developer Guide.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 32
            /// Pattern: (?!^. *--)(?!^[0-9]+$)(?!^-)(?!. *-$)^[A-Za-z0-9-]+$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> StreamName { get; set; }

            /// <summary>
            /// RoleArn
            /// The Amazon Resource Name (ARN) of the IAM role that grants QLDB permissions for a journal stream to
            /// write data records to a Kinesis Data Streams resource.
            /// Required: Yes
            /// Type: String
            /// Minimum: 20
            /// Maximum: 1600
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> RoleArn { get; set; }

            /// <summary>
            /// InclusiveStartTime
            /// The inclusive start date and time from which to start streaming journal data. This parameter must be
            /// in ISO 8601 date and time format and in Universal Coordinated Time (UTC). For example:
            /// 2019-06-13T21:36:34Z.
            /// The InclusiveStartTime cannot be in the future and must be before ExclusiveEndTime.
            /// If you provide an InclusiveStartTime that is before the ledger&#39;s CreationDateTime, QLDB effectively
            /// defaults it to the ledger&#39;s CreationDateTime.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> InclusiveStartTime { get; set; }

            /// <summary>
            /// ExclusiveEndTime
            /// The exclusive date and time that specifies when the stream ends. If you don&#39;t define this parameter,
            /// the stream runs indefinitely until you cancel it.
            /// The ExclusiveEndTime must be in ISO 8601 date and time format and in Universal Coordinated Time
            /// (UTC). For example: 2019-06-13T21:36:34Z.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ExclusiveEndTime { get; set; }

            /// <summary>
            /// KinesisConfiguration
            /// The configuration settings of the Kinesis Data Streams destination for your stream request.
            /// Required: Yes
            /// Type: KinesisConfiguration
            /// Update requires: Replacement
            /// </summary>
            public KinesisConfiguration KinesisConfiguration { get; set; }

            /// <summary>
            /// Tags
            /// An array of key-value pairs to apply to this resource.
            /// For more information, see Tag.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::QLDB::Stream";

        public StreamProperties Properties { get; } = new StreamProperties();

    }

    public static class StreamAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
    }
}
