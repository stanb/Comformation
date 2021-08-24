using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.GroundStation.MissionProfile
{
    /// <summary>
    /// AWS::GroundStation::MissionProfile
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-groundstation-missionprofile.html
    /// </summary>
    public class MissionProfileResource : ResourceBase
    {
        public class MissionProfileProperties
        {
            /// <summary>
            /// Name
            /// The name of the mission profile.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// ContactPrePassDurationSeconds
            /// Amount of time in seconds prior to contact start that you&#39;d like to receive a CloudWatch Event
            /// indicating an upcoming pass. For more information on CloudWatch Events, see the What Is CloudWatch
            /// Events?
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> ContactPrePassDurationSeconds { get; set; }

            /// <summary>
            /// ContactPostPassDurationSeconds
            /// Amount of time in seconds after a contact ends that you’d like to receive a CloudWatch Event
            /// indicating the pass has finished. For more information on CloudWatch Events, see the What Is
            /// CloudWatch Events?
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> ContactPostPassDurationSeconds { get; set; }

            /// <summary>
            /// MinimumViableContactDurationSeconds
            /// Minimum length of a contact in seconds that Ground Station will return when listing contacts. Ground
            /// Station will not return contacts shorter than this duration.
            /// Required: Yes
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> MinimumViableContactDurationSeconds { get; set; }

            /// <summary>
            /// DataflowEdges
            /// A list containing lists of config ARNs. Each list of config ARNs is an edge, with a &quot;from&quot; config
            /// and a &quot;to&quot; config.
            /// Required: Yes
            /// Type: List of DataflowEdge
            /// Update requires: No interruption
            /// </summary>
            public List<DataflowEdge> DataflowEdges { get; set; }

            /// <summary>
            /// TrackingConfigArn
            /// The ARN of a tracking config objects that defines how to track the satellite through the sky during
            /// a contact.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> TrackingConfigArn { get; set; }

            /// <summary>
            /// Tags
            /// Tags assigned to the mission profile.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::GroundStation::MissionProfile";

        public MissionProfileProperties Properties { get; } = new MissionProfileProperties();

    }

    public static class MissionProfileAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Region = new ResourceAttribute<Union<string, IntrinsicFunction>>("Region");
    }
}
