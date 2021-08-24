using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DataBrew.Dataset
{
    /// <summary>
    /// AWS::DataBrew::Dataset Input
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-input.html
    /// </summary>
    public class Input
    {

        /// <summary>
        /// S3InputDefinition
        /// The Amazon S3 location where the data is stored.
        /// Required: No
        /// Type: S3Location
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3InputDefinition")]
        public S3Location S3InputDefinition { get; set; }

        /// <summary>
        /// DataCatalogInputDefinition
        /// The AWS Glue Data Catalog parameters for the data.
        /// Required: No
        /// Type: DataCatalogInputDefinition
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DataCatalogInputDefinition")]
        public DataCatalogInputDefinition DataCatalogInputDefinition { get; set; }

        /// <summary>
        /// DatabaseInputDefinition
        /// Connection information for dataset input files stored in a database.
        /// Required: No
        /// Type: DatabaseInputDefinition
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DatabaseInputDefinition")]
        public DatabaseInputDefinition DatabaseInputDefinition { get; set; }

    }
}
