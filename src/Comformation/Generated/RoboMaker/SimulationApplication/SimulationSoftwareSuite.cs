using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.RoboMaker.SimulationApplication
{
    /// <summary>
    /// AWS::RoboMaker::SimulationApplication SimulationSoftwareSuite
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-robomaker-simulationapplication-simulationsoftwaresuite.html
    /// </summary>
    public class SimulationSoftwareSuite
    {

        /// <summary>
        /// Version
        /// The version of the simulation software suite.
        /// Required: Yes
        /// Type: String
        /// Minimum: 0
        /// Maximum: 1024
        /// Pattern: 7|9|Kinetic|Melodic|Dashing
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Version")]
        public Union<string, IntrinsicFunction> Version { get; set; }

        /// <summary>
        /// Name
        /// The name of the simulation software suite.
        /// Required: Yes
        /// Type: String
        /// Allowed values: Gazebo | RosbagPlay
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
