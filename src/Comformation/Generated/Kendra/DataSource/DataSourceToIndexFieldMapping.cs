using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Kendra.DataSource
{
    /// <summary>
    /// AWS::Kendra::DataSource DataSourceToIndexFieldMapping
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-datasourcetoindexfieldmapping.html
    /// </summary>
    public class DataSourceToIndexFieldMapping
    {

        /// <summary>
        /// DataSourceFieldName
        /// The name of the column or attribute in the data source.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 100
        /// Pattern: ^[a-zA-Z][a-zA-Z0-9_. ]*$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DataSourceFieldName")]
        public Union<string, IntrinsicFunction> DataSourceFieldName { get; set; }

        /// <summary>
        /// DateFieldFormat
        /// The type of data stored in the column or attribute.
        /// Required: No
        /// Type: String
        /// Minimum: 4
        /// Maximum: 40
        /// Pattern: ^(?!\s). *(?&amp;lt;!\s)$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DateFieldFormat")]
        public Union<string, IntrinsicFunction> DateFieldFormat { get; set; }

        /// <summary>
        /// IndexFieldName
        /// The name of the field in the index.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 30
        /// Pattern: ^\P{C}*$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IndexFieldName")]
        public Union<string, IntrinsicFunction> IndexFieldName { get; set; }

    }
}
