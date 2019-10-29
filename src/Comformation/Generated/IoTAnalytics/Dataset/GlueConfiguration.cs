using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Dataset
{
    /// <summary>
    /// AWS::IoTAnalytics::Dataset GlueConfiguration
    /// Configuration information for coordination with the AWS Glue ETL (extract, transform and load) service.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-glueconfiguration.html
    /// </summary>
    public class GlueConfiguration
    {

        /// <summary>
        /// TableName
        /// The name of the table in your AWS Glue Data Catalog which is used to perform the ETL (extract,
        /// transform and load) operations. (An AWS Glue Data Catalog table contains partitioned data and
        /// descriptions of data sources and targets. )
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 150
        /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\t]*
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TableName")]
        public Union<string, IntrinsicFunction> TableName { get; set; }

        /// <summary>
        /// DatabaseName
        /// The name of the database in your AWS Glue Data Catalog in which the table is located. (An AWS Glue
        /// Data Catalog database contains Glue Data tables. )
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 150
        /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\t]*
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DatabaseName")]
        public Union<string, IntrinsicFunction> DatabaseName { get; set; }

    }
}
