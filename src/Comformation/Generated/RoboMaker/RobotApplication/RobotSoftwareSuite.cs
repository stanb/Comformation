using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.RoboMaker.RobotApplication
{
    /// <summary>
    /// RoboMaker RobotApplication RobotSoftwareSuite
    /// The RobotSoftwareSuite property type specifies the robotsoftware suite for an AWS RoboMaker robot application.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-robomaker-robotapplication-robotsoftwaresuite.html
    /// </summary>
    public class RobotSoftwareSuite
    {

        /// <summary>
        /// Version
        /// The version of the robot software suite.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Version")]
        public Union<string, IntrinsicFunction> Version { get; set; }

        /// <summary>
        /// Name
        /// The name of the robot software suite.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
