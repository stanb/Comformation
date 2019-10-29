using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Pinpoint.Segment
{
    /// <summary>
    /// AWS::Pinpoint::Segment
    /// Creates a new segment for an application or updates the configuration, dimension, and other settings for an
    /// existing segment that&#39;s associated with an application.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-segment.html
    /// </summary>
    public class SegmentResource : ResourceBase
    {
        public class SegmentProperties
        {
            /// <summary>
            /// SegmentGroups
            /// The segment group to use and the dimensions to apply to the group&#39;s base segments in order to build
            /// the segment. A segment group can consist of zero or more base segments. Your request can include
            /// only one segment group.
            /// Required: No
            /// Type: SegmentGroups
            /// Update requires: No interruption
            /// </summary>
			public SegmentGroups SegmentGroups { get; set; }

            /// <summary>
            /// Dimensions
            /// The criteria that define the dimensions for the segment.
            /// Required: No
            /// Type: SegmentDimensions
            /// Update requires: No interruption
            /// </summary>
			public SegmentDimensions Dimensions { get; set; }

            /// <summary>
            /// ApplicationId
            /// The unique ID of the Amazon Pinpoint app that the segment is associated with.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ApplicationId { get; set; }

            /// <summary>
            /// Tags
            /// A string-to-string map of key-value pairs that defines the tags to associate with the segment. Each
            /// tag consists of a required tag key and an associated tag value.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Tags { get; set; }

            /// <summary>
            /// Name
            /// The name of the segment.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::Pinpoint::Segment";

        public SegmentProperties Properties { get; } = new SegmentProperties();

    }

	public static class SegmentAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> SegmentId = new ResourceAttribute<Union<string, IntrinsicFunction>>("SegmentId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
	}
}
