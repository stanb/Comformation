using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.RoboMaker.SimulationApplication
{
    /// <summary>
    /// AWS::RoboMaker::SimulationApplication SourceConfig
    /// Information about a source configuration.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-robomaker-simulationapplication-sourceconfig.html
    /// </summary>
    public class SourceConfig
    {

        /// <summary>
        /// S3Bucket
        /// The Amazon S3 bucket name.
        /// Required: Yes
        /// Type: String
        /// Minimum: 3
        /// Maximum: 63
        /// Pattern: [a-z0-9][a-z0-9. \-]*[a-z0-9]
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3Bucket")]
        public Union<string, IntrinsicFunction> S3Bucket { get; set; }

        /// <summary>
        /// Architecture
        /// The target processor architecture for the application.
        /// Required: Yes
        /// Type: String
        /// Allowed Values: ARM64 | ARMHF | X86_64
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Architecture")]
        public Union<string, IntrinsicFunction> Architecture { get; set; }

        /// <summary>
        /// S3Key
        /// The s3 object key.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1024
        /// Pattern: . *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3Key")]
        public Union<string, IntrinsicFunction> S3Key { get; set; }

    }
}
