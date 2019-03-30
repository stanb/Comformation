using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.RoboMaker.RobotApplicationVersion
{
    /// <summary>
    /// AWS::RoboMaker::RobotApplicationVersion
    /// The AWS::RoboMaker::RobotApplicationVersion resource creates a version of an AWS RoboMaker robot application.
    /// For more information, see API_CreateRobotApplicationVersion in the RoboMaker Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-robomaker-robotapplicationversion.html
    /// </summary>
    public class RobotApplicationVersionResource : ResourceBase
    {
        public class RobotApplicationVersionProperties
        {
            /// <summary>
            /// CurrentRevisionId
            /// Current revision id.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> CurrentRevisionId { get; set; }

            /// <summary>
            /// Application
            /// The the Amazon Resource Name (ARN) robot application to version.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Application { get; set; }

        }

        public string Type { get; } = "AWS::RoboMaker::RobotApplicationVersion";

        public RobotApplicationVersionProperties Properties { get; } = new RobotApplicationVersionProperties();

    }
}
