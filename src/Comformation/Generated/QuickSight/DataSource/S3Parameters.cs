using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.DataSource
{
    /// <summary>
    /// AWS::QuickSight::DataSource S3Parameters
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-s3parameters.html
    /// </summary>
    public class S3Parameters
    {

        /// <summary>
        /// ManifestFileLocation
        /// Location of the Amazon S3 manifest file. This is NULL if the manifest file was uploaded into
        /// QuickSight.
        /// Required: Yes
        /// Type: ManifestFileLocation
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ManifestFileLocation")]
        public ManifestFileLocation ManifestFileLocation { get; set; }

    }
}
