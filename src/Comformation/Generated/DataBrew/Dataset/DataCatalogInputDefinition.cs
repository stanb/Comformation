using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DataBrew.Dataset
{
    /// <summary>
    /// AWS::DataBrew::Dataset DataCatalogInputDefinition
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-datacataloginputdefinition.html
    /// </summary>
    public class DataCatalogInputDefinition
    {

        /// <summary>
        /// CatalogId
        /// The unique identifier of the AWS account that holds the Data Catalog that stores the data.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 255
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CatalogId")]
        public Union<string, IntrinsicFunction> CatalogId { get; set; }

        /// <summary>
        /// DatabaseName
        /// The name of a database in the Data Catalog.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 255
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DatabaseName")]
        public Union<string, IntrinsicFunction> DatabaseName { get; set; }

        /// <summary>
        /// TableName
        /// The name of a database table in the Data Catalog. This table corresponds to a DataBrew dataset.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 255
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TableName")]
        public Union<string, IntrinsicFunction> TableName { get; set; }

        /// <summary>
        /// TempDirectory
        /// An Amazon location that AWS Glue Data Catalog can use as a temporary directory.
        /// Required: No
        /// Type: S3Location
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TempDirectory")]
        public S3Location TempDirectory { get; set; }

    }
}
