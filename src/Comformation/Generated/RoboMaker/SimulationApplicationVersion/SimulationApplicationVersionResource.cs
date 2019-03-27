using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.RoboMaker.SimulationApplicationVersion
{
    /// <summary>
    /// AWS::RoboMaker::SimulationApplicationVersion
    /// The AWS::RoboMaker::SimulationApplicationVersion resource creates a version of an AWS RoboMaker simulation
    /// application. For more information, see API_CreateSimulationApplicationVersion in the RoboMaker Developer
    /// Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-robomaker-simulationapplicationversion.html
    /// </summary>
    public class SimulationApplicationVersionResource : ResourceBase
    {
        public class SimulationApplicationVersionProperties
        {
            /// <summary>
            /// CurrentRevisionId
            /// The current revision id.
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

        public string Type { get; } = "AWS::RoboMaker::SimulationApplicationVersion";

        public SimulationApplicationVersionProperties Properties { get; } = new SimulationApplicationVersionProperties();

    }
}
