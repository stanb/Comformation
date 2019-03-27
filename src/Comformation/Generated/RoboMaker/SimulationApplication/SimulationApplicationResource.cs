using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.RoboMaker.SimulationApplication
{
    /// <summary>
    /// AWS::RoboMaker::SimulationApplication
    /// The AWS::RoboMaker::SimulationApplication resource creates an AWS RoboMaker simulation application. For more
    /// information, see API_CreateSimulationApplication in the RoboMaker Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-robomaker-simulationapplication.html
    /// </summary>
    public class SimulationApplicationResource : ResourceBase
    {
        public class SimulationApplicationProperties
        {
            /// <summary>
            /// RenderingEngine
            /// The rendering engine.
            /// Required: Yes
            /// Type: RenderingEngine
            /// Update requires: Replacement
            /// </summary>
			public RenderingEngine RenderingEngine { get; set; }

            /// <summary>
            /// SimulationSoftwareSuite
            /// The simulation software suite.
            /// Required: Yes
            /// Type: SimulationSoftwareSuite
            /// Update requires: Replacement
            /// </summary>
			public SimulationSoftwareSuite SimulationSoftwareSuite { get; set; }

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
            /// The sources of the simulation application.
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
            /// The name of the simulation application.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::RoboMaker::SimulationApplication";

        public SimulationApplicationProperties Properties { get; } = new SimulationApplicationProperties();

    }

	public static class SimulationApplicationAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CurrentRevisionId = new ResourceAttribute<Union<string, IntrinsicFunction>>("CurrentRevisionId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
	}
}
