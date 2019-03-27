using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.RoboMaker.SimulationApplication
{
    /// <summary>
    /// RoboMaker SimulationApplication SourceConfig
    /// The SourceConfig property type specifies the source configuration for an AWS RoboMaker simulation application.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-robomaker-simulationapplication-sourceconfig.html
    /// </summary>
    public class SourceConfig
    {

        /// <summary>
        /// S3Bucket
        /// The Amazon S3 bucket name.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3Bucket")]
        public Union<string, IntrinsicFunction> S3Bucket { get; set; }

        /// <summary>
        /// Architecture
        /// The target processor architecture.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Architecture")]
        public Union<string, IntrinsicFunction> Architecture { get; set; }

        /// <summary>
        /// S3Key
        /// The Amazon S3 object key.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3Key")]
        public Union<string, IntrinsicFunction> S3Key { get; set; }

    }
}
