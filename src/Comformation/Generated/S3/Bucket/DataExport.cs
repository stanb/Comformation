using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// AWS::S3::Bucket DataExport
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-dataexport.html
    /// </summary>
    public class DataExport
    {

        /// <summary>
        /// Destination
        /// The place to store the data for an analysis.
        /// Required: Yes
        /// Type: Destination
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Destination")]
        public Destination Destination { get; set; }

        /// <summary>
        /// OutputSchemaVersion
        /// The version of the output schema to use when exporting data. Must be V_1.
        /// Required: Yes
        /// Type: String
        /// Allowed values: V_1
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OutputSchemaVersion")]
        public Union<string, IntrinsicFunction> OutputSchemaVersion { get; set; }

    }
}
