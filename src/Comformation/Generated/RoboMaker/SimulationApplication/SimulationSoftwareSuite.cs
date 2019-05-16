using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.RoboMaker.SimulationApplication
{
    /// <summary>
    /// AWS::RoboMaker::SimulationApplication SimulationSoftwareSuite
    /// Information about a simulation software suite.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-robomaker-simulationapplication-simulationsoftwaresuite.html
    /// </summary>
    public class SimulationSoftwareSuite
    {

        /// <summary>
        /// Version
        /// The version of the simulation software suite.
        /// Required: Yes
        /// Type: String
        /// Pattern: 7|9
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Version")]
        public Union<string, IntrinsicFunction> Version { get; set; }

        /// <summary>
        /// Name
        /// The name of the simulation software suite.
        /// Required: Yes
        /// Type: String
        /// Allowed Values: Gazebo
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
