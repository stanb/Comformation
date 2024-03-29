using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.RoboMaker.SimulationApplication
{
    /// <summary>
    /// AWS::RoboMaker::SimulationApplication RobotSoftwareSuite
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-robomaker-simulationapplication-robotsoftwaresuite.html
    /// </summary>
    public class RobotSoftwareSuite
    {

        /// <summary>
        /// Version
        /// The version of the robot software suite (ROS distribution).
        /// Required: Yes
        /// Type: String
        /// Allowed values: Dashing | Foxy | Kinetic | Melodic
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Version")]
        public Union<string, IntrinsicFunction> Version { get; set; }

        /// <summary>
        /// Name
        /// The name of the robot software suite (ROS distribution).
        /// Required: Yes
        /// Type: String
        /// Allowed values: ROS | ROS2
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
