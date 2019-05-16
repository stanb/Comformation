using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalyticsV2.ApplicationReferenceDataSource
{
    /// <summary>
    /// AWS::KinesisAnalyticsV2::ApplicationReferenceDataSource ReferenceDataSource
    /// For an SQL-based Amazon Kinesis Data Analytics application, describes the reference data source by providing
    /// the source information (Amazon S3 bucket name and object key name), the resulting in-application table name
    /// that is created, and the necessary schema to map the data elements in the Amazon S3 object to the
    /// in-application table.
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
        /// Minimum: 1
        /// Maximum: 32
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("TableName")]
        public Union<string, IntrinsicFunction> TableName { get; set; }

        /// <summary>
        /// S3ReferenceDataSource
        /// Identifies the S3 bucket and object that contains the reference data. A Kinesis Data Analytics
        /// application loads reference data only once. If the data changes, you call the UpdateApplication
        /// operation to trigger reloading of data into your application.
        /// Required: No
        /// Type: S3ReferenceDataSource
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3ReferenceDataSource")]
        public S3ReferenceDataSource S3ReferenceDataSource { get; set; }

    }
}
