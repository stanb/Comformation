using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisFirehose.DeliveryStream
{
    /// <summary>
    /// AWS::KinesisFirehose::DeliveryStream SchemaConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-schemaconfiguration.html
    /// </summary>
    public class SchemaConfiguration
    {

        /// <summary>
        /// CatalogId
        /// The ID of the AWS Glue Data Catalog. If you don&#39;t supply this, the AWS account ID is used by
        /// default.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1024
        /// Pattern: ^\S+$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CatalogId")]
        public Union<string, IntrinsicFunction> CatalogId { get; set; }

        /// <summary>
        /// DatabaseName
        /// Specifies the name of the AWS Glue database that contains the schema for the output data.
        /// Important If the SchemaConfiguration request parameter is used as part of invoking the
        /// CreateDeliveryStream API, then the DatabaseName property is required and its value must be
        /// specified.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1024
        /// Pattern: ^\S+$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DatabaseName")]
        public Union<string, IntrinsicFunction> DatabaseName { get; set; }

        /// <summary>
        /// Region
        /// If you don&#39;t specify an AWS Region, the default is the current Region.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1024
        /// Pattern: ^\S+$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Region")]
        public Union<string, IntrinsicFunction> Region { get; set; }

        /// <summary>
        /// RoleARN
        /// The role that Kinesis Data Firehose can use to access AWS Glue. This role must be in the same
        /// account you use for Kinesis Data Firehose. Cross-account roles aren&#39;t allowed.
        /// Important If the SchemaConfiguration request parameter is used as part of invoking the
        /// CreateDeliveryStream API, then the RoleARN property is required and its value must be specified.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1024
        /// Pattern: ^\S+$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleARN")]
        public Union<string, IntrinsicFunction> RoleARN { get; set; }

        /// <summary>
        /// TableName
        /// Specifies the AWS Glue table that contains the column information that constitutes your data schema.
        /// Important If the SchemaConfiguration request parameter is used as part of invoking the
        /// CreateDeliveryStream API, then the TableName property is required and its value must be specified.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1024
        /// Pattern: ^\S+$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TableName")]
        public Union<string, IntrinsicFunction> TableName { get; set; }

        /// <summary>
        /// VersionId
        /// Specifies the table version for the output data schema. If you don&#39;t specify this version ID, or if
        /// you set it to LATEST, Kinesis Data Firehose uses the most recent version. This means that any
        /// updates to the table are automatically picked up.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1024
        /// Pattern: ^\S+$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VersionId")]
        public Union<string, IntrinsicFunction> VersionId { get; set; }

    }
}
