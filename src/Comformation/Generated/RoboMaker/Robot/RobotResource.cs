using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.RoboMaker.Robot
{
    /// <summary>
    /// AWS::RoboMaker::Robot
    /// The AWS::RoboMaker::Robot resource creates an AWS RoboMaker robot. For more information, see API_CreateRobot
    /// in the RoboMaker Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-robomaker-robot.html
    /// </summary>
    public class RobotResource : ResourceBase
    {
        public class RobotProperties
        {
            /// <summary>
            /// Fleet
            /// The fleet to which the robot is enlisted.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Fleet { get; set; }

            /// <summary>
            /// Architecture
            /// The target architecture of the robot.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Architecture { get; set; }

            /// <summary>
            /// GreengrassGroupId
            /// The AWS GreenGrass group id.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> GreengrassGroupId { get; set; }

            /// <summary>
            /// Tags
            /// An array of key-value pairs. For more information, see Using Cost Allocation Tags in the AWS Billing
            /// and Cost Management User Guide.
            /// Required: No
            /// Type: JSON object
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Tags { get; set; }

            /// <summary>
            /// Name
            /// The name of the robot.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::RoboMaker::Robot";

        public RobotProperties Properties { get; } = new RobotProperties();

    }
}
