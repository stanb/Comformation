using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.RoboMaker.Robot
{
    /// <summary>
    /// AWS::RoboMaker::Robot
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-robomaker-robot.html
    /// </summary>
    public class RobotResource : ResourceBase
    {
        public class RobotProperties
        {
            /// <summary>
            /// Fleet
            /// The Amazon Resource Name (ARN) of the fleet to which the robot will be registered.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Fleet { get; set; }

            /// <summary>
            /// Architecture
            /// The architecture of the robot.
            /// Required: Yes
            /// Type: String
            /// Allowed values: ARM64 | ARMHF | X86_64
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Architecture { get; set; }

            /// <summary>
            /// GreengrassGroupId
            /// The Greengrass group associated with the robot.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1224
            /// Pattern: . *
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> GreengrassGroupId { get; set; }

            /// <summary>
            /// Tags
            /// A map that contains tag keys and tag values that are attached to the robot.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Tags { get; set; }

            /// <summary>
            /// Name
            /// The name of the robot.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 255
            /// Pattern: [a-zA-Z0-9_\-]*
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::RoboMaker::Robot";

        public RobotProperties Properties { get; } = new RobotProperties();

    }
}
