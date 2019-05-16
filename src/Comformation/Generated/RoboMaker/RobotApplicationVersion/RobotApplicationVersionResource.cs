using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.RoboMaker.RobotApplicationVersion
{
    /// <summary>
    /// AWS::RoboMaker::RobotApplicationVersion
    /// The AWS::RoboMaker::RobotApplicationVersion resource creates an AWS RoboMaker robot version.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-robomaker-robotapplicationversion.html
    /// </summary>
    public class RobotApplicationVersionResource : ResourceBase
    {
        public class RobotApplicationVersionProperties
        {
            /// <summary>
            /// CurrentRevisionId
            /// The current revision id for the robot application. If you provide a value and it matches the latest
            /// revision ID, a new version will be created.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 40
            /// Pattern: [a-zA-Z0-9_. \-]*
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> CurrentRevisionId { get; set; }

            /// <summary>
            /// Application
            /// The application information for the robot application.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1224
            /// Pattern: arn:. *
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Application { get; set; }

        }

        public string Type { get; } = "AWS::RoboMaker::RobotApplicationVersion";

        public RobotApplicationVersionProperties Properties { get; } = new RobotApplicationVersionProperties();

    }
}
