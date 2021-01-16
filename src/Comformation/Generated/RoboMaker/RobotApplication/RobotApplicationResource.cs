using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.RoboMaker.RobotApplication
{
    /// <summary>
    /// AWS::RoboMaker::RobotApplication
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-robomaker-robotapplication.html
    /// </summary>
    public class RobotApplicationResource : ResourceBase
    {
        public class RobotApplicationProperties
        {
            /// <summary>
            /// CurrentRevisionId
            /// The current revision id.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> CurrentRevisionId { get; set; }

            /// <summary>
            /// RobotSoftwareSuite
            /// The robot software suite (ROS distribuition) used by the robot application.
            /// Required: Yes
            /// Type: RobotSoftwareSuite
            /// Update requires: Replacement
            /// </summary>
            public RobotSoftwareSuite RobotSoftwareSuite { get; set; }

            /// <summary>
            /// Sources
            /// The sources of the robot application.
            /// Required: Yes
            /// Type: List of SourceConfig
            /// Update requires: No interruption
            /// </summary>
            public List<SourceConfig> Sources { get; set; }

            /// <summary>
            /// Tags
            /// A map that contains tag keys and tag values that are attached to the robot application.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Tags { get; set; }

            /// <summary>
            /// Name
            /// The name of the robot application.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 255
            /// Pattern: [a-zA-Z0-9_\-]*
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::RoboMaker::RobotApplication";

        public RobotApplicationProperties Properties { get; } = new RobotApplicationProperties();

    }

    public static class RobotApplicationAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CurrentRevisionId = new ResourceAttribute<Union<string, IntrinsicFunction>>("CurrentRevisionId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
