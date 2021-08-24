using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.DataSet
{
    /// <summary>
    /// AWS::QuickSight::DataSet RelationalTable
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-relationaltable.html
    /// </summary>
    public class RelationalTable
    {

        /// <summary>
        /// DataSourceArn
        /// The Amazon Resource Name (ARN) for the data source.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DataSourceArn")]
        public Union<string, IntrinsicFunction> DataSourceArn { get; set; }

        /// <summary>
        /// InputColumns
        /// The column schema of the table.
        /// Required: Yes
        /// Type: List of InputColumn
        /// Maximum: 2048
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InputColumns")]
        public List<InputColumn> InputColumns { get; set; }

        /// <summary>
        /// Schema
        /// The schema name. This name applies to certain relational database engines.
        /// Required: No
        /// Type: String
        /// Maximum: 64
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Schema")]
        public Union<string, IntrinsicFunction> Schema { get; set; }

        /// <summary>
        /// Catalog
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Catalog")]
        public Union<string, IntrinsicFunction> Catalog { get; set; }

        /// <summary>
        /// Name
        /// The name of the relational table.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 64
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
