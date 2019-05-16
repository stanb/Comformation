using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.RoboMaker.SimulationApplication
{
    /// <summary>
    /// AWS::RoboMaker::SimulationApplication RenderingEngine
    /// Information about a rendering engine.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-robomaker-simulationapplication-renderingengine.html
    /// </summary>
    public class RenderingEngine
    {

        /// <summary>
        /// Version
        /// The version of the rendering engine.
        /// Required: Yes
        /// Type: String
        /// Pattern: 1. x
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Version")]
        public Union<string, IntrinsicFunction> Version { get; set; }

        /// <summary>
        /// Name
        /// The name of the rendering engine.
        /// Required: Yes
        /// Type: String
        /// Allowed Values: OGRE
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
