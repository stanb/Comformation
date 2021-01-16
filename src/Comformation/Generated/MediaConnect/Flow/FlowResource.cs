using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaConnect.Flow
{
    /// <summary>
    /// AWS::MediaConnect::Flow
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flow.html
    /// </summary>
    public class FlowResource : ResourceBase
    {
        public class FlowProperties
        {
            /// <summary>
            /// Name
            /// The name of the entitlement. This value must be unique within the current flow.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// AvailabilityZone
            /// The Availability Zone that you want to create the flow in. These options are limited to the
            /// Availability Zones within the current AWS Region.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> AvailabilityZone { get; set; }

            /// <summary>
            /// Source
            /// The settings for the source that you want to use for the new flow.
            /// Required: Yes
            /// Type: Source
            /// Update requires: No interruption
            /// </summary>
            public Source Source { get; set; }

            /// <summary>
            /// SourceFailoverConfig
            /// The settings for source failover.
            /// Required: No
            /// Type: FailoverConfig
            /// Update requires: No interruption
            /// </summary>
            public FailoverConfig SourceFailoverConfig { get; set; }

        }

        public string Type { get; } = "AWS::MediaConnect::Flow";

        public FlowProperties Properties { get; } = new FlowProperties();

    }

    public static class FlowAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> FlowArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("FlowArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> FlowAvailabilityZone = new ResourceAttribute<Union<string, IntrinsicFunction>>("FlowAvailabilityZone");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> SourceArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("SourceArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> IngestIp = new ResourceAttribute<Union<string, IntrinsicFunction>>("IngestIp");
    }
}
