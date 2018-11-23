using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// Amazon S3 Bucket DataExport
    /// The DataExport property type specifies how data related to the storage class analysis should be exported for
    /// an Amazon S3 bucket.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-dataexport.html
    /// </summary>
    public class DataExport
    {

        /// <summary>
        /// Destination
        /// Information about where to publish the analytics results.
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
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OutputSchemaVersion")]
        public Union<string, IntrinsicFunction> OutputSchemaVersion { get; set; }

    }
}
