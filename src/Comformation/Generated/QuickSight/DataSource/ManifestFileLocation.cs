using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.DataSource
{
    /// <summary>
    /// AWS::QuickSight::DataSource ManifestFileLocation
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-manifestfilelocation.html
    /// </summary>
    public class ManifestFileLocation
    {

        /// <summary>
        /// Bucket
        /// Amazon S3 bucket.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1024
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Bucket")]
        public Union<string, IntrinsicFunction> Bucket { get; set; }

        /// <summary>
        /// Key
        /// Amazon S3 key that identifies an object.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1024
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

    }
}
