using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DataBrew.Dataset
{
    /// <summary>
    /// AWS::DataBrew::Dataset DatabaseInputDefinition
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-databaseinputdefinition.html
    /// </summary>
    public class DatabaseInputDefinition
    {

        /// <summary>
        /// GlueConnectionName
        /// The AWS Glue Connection that stores the connection information for the target database.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("GlueConnectionName")]
        public Union<string, IntrinsicFunction> GlueConnectionName { get; set; }

        /// <summary>
        /// DatabaseTableName
        /// The table within the target database.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DatabaseTableName")]
        public Union<string, IntrinsicFunction> DatabaseTableName { get; set; }

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
