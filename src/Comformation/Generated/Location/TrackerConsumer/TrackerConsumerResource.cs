using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Location.TrackerConsumer
{
    /// <summary>
    /// AWS::Location::TrackerConsumer
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-location-trackerconsumer.html
    /// </summary>
    public class TrackerConsumerResource : ResourceBase
    {
        public class TrackerConsumerProperties
        {
            /// <summary>
            /// ConsumerArn
            /// The Amazon Resource Name (ARN) for the geofence collection to be disassociated from the tracker
            /// resource. Used when you need to specify a resource across all AWS.
            /// Format example: arn:aws:geo:region:account-id:geofence-collection/ExampleGeofenceCollectionConsumer
            /// Required: Yes
            /// Type: String
            /// Minimum: 0
            /// Maximum: 1600
            /// Pattern: ^arn(:[a-z0-9]+([. -][a-z0-9]+)*){2}(:([a-z0-9]+([. -][a-z0-9]+)*)?){2}:([^/]. *)?$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ConsumerArn { get; set; }

            /// <summary>
            /// TrackerName
            /// The name for the tracker resource.
            /// Requirements:
            /// Contain only alphanumeric characters (A-Z, a-z, 0-9) , hyphens (-), periods (. ), and underscores
            /// (_). Must be a unique tracker resource name. No spaces allowed. For example, ExampleTracker.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 100
            /// Pattern: ^[-. _\w]+$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> TrackerName { get; set; }

        }

        public string Type { get; } = "AWS::Location::TrackerConsumer";

        public TrackerConsumerProperties Properties { get; } = new TrackerConsumerProperties();

    }
}
