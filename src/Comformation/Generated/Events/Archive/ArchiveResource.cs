using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Events.Archive
{
    /// <summary>
    /// AWS::Events::Archive
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-events-archive.html
    /// </summary>
    public class ArchiveResource : ResourceBase
    {
        public class ArchiveProperties
        {
            /// <summary>
            /// ArchiveName
            /// The name of the archive.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ArchiveName { get; set; }

            /// <summary>
            /// SourceArn
            /// The ARN of the event source associated with the archive.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> SourceArn { get; set; }

            /// <summary>
            /// Description
            /// A description for the archive.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// EventPattern
            /// An event pattern to use to filter events sent to the archive.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> EventPattern { get; set; }

            /// <summary>
            /// RetentionDays
            /// The number of days to retain events for. Default value is 0. If set to 0, events are retained
            /// indefinitely.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> RetentionDays { get; set; }

        }

        public string Type { get; } = "AWS::Events::Archive";

        public ArchiveProperties Properties { get; } = new ArchiveProperties();

    }

    public static class ArchiveAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ArchiveName = new ResourceAttribute<Union<string, IntrinsicFunction>>("ArchiveName");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
