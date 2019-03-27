using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.RoboMaker.RobotApplication
{
    /// <summary>
    /// AWS::RoboMaker::RobotApplication
    /// The AWS::RoboMaker::RobotApplication resource creates an AWS RoboMaker robot application. For more
    /// information, see API_CreateRobotApplication in the RoboMaker Developer Guide.
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
            /// The robot software suite.
            /// Required: Yes
            /// Type: RobotSoftwareSuite
            /// Update requires: Replacement
            /// </summary>
			public RobotSoftwareSuite RobotSoftwareSuite { get; set; }

            /// <summary>
            /// Sources
            /// The sources of the robot application.
            /// Required: Yes
            /// Type: List of SourceConfig property types
            /// Update requires: No interruption
            /// </summary>
			public List<SourceConfig> Sources { get; set; }

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
            /// The name of the robot application.
            /// Required: No
            /// Type: String
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
