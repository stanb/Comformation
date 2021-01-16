using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.MLTransform
{
    /// <summary>
    /// AWS::Glue::MLTransform GlueTables
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-mltransform-inputrecordtables-gluetables.html
    /// </summary>
    public class GlueTables
    {

        /// <summary>
        /// ConnectionName
        /// The name of the connection to the AWS Glue Data Catalog.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ConnectionName")]
        public Union<string, IntrinsicFunction> ConnectionName { get; set; }

        /// <summary>
        /// TableName
        /// A table name in the AWS Glue Data Catalog.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TableName")]
        public Union<string, IntrinsicFunction> TableName { get; set; }

        /// <summary>
        /// DatabaseName
        /// A database name in the AWS Glue Data Catalog.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DatabaseName")]
        public Union<string, IntrinsicFunction> DatabaseName { get; set; }

        /// <summary>
        /// CatalogId
        /// A unique identifier for the AWS Glue Data Catalog.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CatalogId")]
        public Union<string, IntrinsicFunction> CatalogId { get; set; }

    }
}
