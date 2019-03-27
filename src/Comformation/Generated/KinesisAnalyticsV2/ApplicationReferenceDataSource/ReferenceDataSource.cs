using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalyticsV2.ApplicationReferenceDataSource
{
    /// <summary>
    /// Amazon Kinesis Data Analytics ApplicationReferenceDataSource ReferenceDataSource
    /// The ReferenceDataSource property type specifies the reference data source for a SQL-based Amazon Kinesis Data
    /// Analytics application.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-applicationreferencedatasource-referencedatasource.html
    /// </summary>
    public class ReferenceDataSource
    {

        /// <summary>
        /// ReferenceSchema
        /// Describes the format of the data in the streaming source, and how each data element maps to
        /// corresponding columns created in the in-application stream.
        /// Required: Yes
        /// Type: ReferenceSchema
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ReferenceSchema")]
        public ReferenceSchema ReferenceSchema { get; set; }

        /// <summary>
        /// TableName
        /// The name of the in-application table to create.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("TableName")]
        public Union<string, IntrinsicFunction> TableName { get; set; }

        /// <summary>
        /// S3ReferenceDataSource
        /// Identifies the S3 bucket and object that contains the reference data.
        /// Required: No
        /// Type: S3ReferenceDataSource
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3ReferenceDataSource")]
        public S3ReferenceDataSource S3ReferenceDataSource { get; set; }

    }
}
