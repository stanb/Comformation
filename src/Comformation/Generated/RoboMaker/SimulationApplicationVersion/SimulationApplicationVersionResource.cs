using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.RoboMaker.SimulationApplicationVersion
{
    /// <summary>
    /// AWS::RoboMaker::SimulationApplicationVersion
    /// The AWS::RoboMaker::SimulationApplicationVersion resource creates a version of an AWS RoboMaker simulation
    /// application.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-robomaker-simulationapplicationversion.html
    /// </summary>
    public class SimulationApplicationVersionResource : ResourceBase
    {
        public class SimulationApplicationVersionProperties
        {
            /// <summary>
            /// CurrentRevisionId
            /// The current revision id for the simulation application. If you provide a value and it matches the
            /// latest revision ID, a new version will be created.
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
            /// The application information for the simulation application.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1224
            /// Pattern: arn:. *
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Application { get; set; }

        }

        public string Type { get; } = "AWS::RoboMaker::SimulationApplicationVersion";

        public SimulationApplicationVersionProperties Properties { get; } = new SimulationApplicationVersionProperties();

    }
}
