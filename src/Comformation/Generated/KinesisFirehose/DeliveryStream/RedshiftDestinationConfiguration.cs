using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisFirehose.DeliveryStream
{
    /// <summary>
    /// Amazon Kinesis Data Firehose DeliveryStream RedshiftDestinationConfiguration
    /// The RedshiftDestinationConfiguration property type specifies an Amazon Redshift cluster to which Amazon
    /// Kinesis Data Firehose (Kinesis Data Firehose) delivers data.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-redshiftdestinationconfiguration.html
    /// </summary>
    public class RedshiftDestinationConfiguration
    {

        /// <summary>
        /// CloudWatchLoggingOptions
        /// The Amazon CloudWatch Logs logging options for the delivery stream.
        /// Required: No
        /// Type: CloudWatchLoggingOptions
        /// </summary>
        [JsonProperty("CloudWatchLoggingOptions")]
        public CloudWatchLoggingOptions CloudWatchLoggingOptions { get; set; }

        /// <summary>
        /// ClusterJDBCURL
        /// The connection string that Kinesis Data Firehose uses to connect to the Amazon Redshift cluster.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("ClusterJDBCURL")]
        public Union<string, IntrinsicFunction> ClusterJDBCURL { get; set; }

        /// <summary>
        /// CopyCommand
        /// Configures the Amazon Redshift COPY command that Kinesis Data Firehose uses to load data into the
        /// cluster from the Amazon S3 bucket.
        /// Required: Yes
        /// Type: CopyCommand
        /// </summary>
        [JsonProperty("CopyCommand")]
        public CopyCommand CopyCommand { get; set; }

        /// <summary>
        /// Password
        /// The password for the Amazon Redshift user that you specified in the Username property.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Password")]
        public Union<string, IntrinsicFunction> Password { get; set; }

        /// <summary>
        /// ProcessingConfiguration
        /// The data processing configuration for the Kinesis Data Firehose delivery stream.
        /// Required: No
        /// Type: ProcessingConfiguration
        /// </summary>
        [JsonProperty("ProcessingConfiguration")]
        public ProcessingConfiguration ProcessingConfiguration { get; set; }

        /// <summary>
        /// RoleARN
        /// The ARN of the AWS Identity and Access Management (IAM) role that grants Kinesis Data Firehose
        /// access to your Amazon S3 bucket and AWS KMS (if you enable data encryption).
        /// For more information, see Grant Kinesis Data Firehose Access to an Amazon Redshift Destination in
        /// the Amazon Kinesis Data Firehose Developer Guide.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("RoleARN")]
        public Union<string, IntrinsicFunction> RoleARN { get; set; }

        /// <summary>
        /// S3Configuration
        /// The S3 bucket where Kinesis Data Firehose first delivers data. After the data is in the bucket,
        /// Kinesis Data Firehose uses the COPY command to load the data into the Amazon Redshift cluster. For
        /// the Amazon S3 bucket&#39;s compression format, don&#39;t specify SNAPPY or ZIP because the Amazon Redshift
        /// COPY command doesn&#39;t support them.
        /// Required: Yes
        /// Type: S3DestinationConfiguration
        /// </summary>
        [JsonProperty("S3Configuration")]
        public S3DestinationConfiguration S3Configuration { get; set; }

        /// <summary>
        /// Username
        /// The Amazon Redshift user that has permission to access the Amazon Redshift cluster. This user must
        /// have INSERT privileges for copying data from the Amazon S3 bucket to the cluster.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Username")]
        public Union<string, IntrinsicFunction> Username { get; set; }

    }
}
