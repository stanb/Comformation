using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppFlow.ConnectorProfile
{
    /// <summary>
    /// AWS::AppFlow::ConnectorProfile SnowflakeConnectorProfileProperties
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-snowflakeconnectorprofileproperties.html
    /// </summary>
    public class SnowflakeConnectorProfileProperties
    {

        /// <summary>
        /// Warehouse
        /// The name of the Snowflake warehouse.
        /// Required: Yes
        /// Type: String
        /// Maximum: 512
        /// Pattern: [\s\w/!@#+=. -]*
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Warehouse")]
        public Union<string, IntrinsicFunction> Warehouse { get; set; }

        /// <summary>
        /// Stage
        /// The name of the Amazon S3 stage that was created while setting up an Amazon S3 stage in the
        /// Snowflake account. This is written in the following format: &amp;lt; Database&amp;gt;&amp;lt;
        /// Schema&amp;gt;&amp;lt;Stage Name&amp;gt;.
        /// Required: Yes
        /// Type: String
        /// Maximum: 512
        /// Pattern: \S+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Stage")]
        public Union<string, IntrinsicFunction> Stage { get; set; }

        /// <summary>
        /// BucketName
        /// The name of the Amazon S3 bucket associated with Snowflake.
        /// Required: Yes
        /// Type: String
        /// Minimum: 3
        /// Maximum: 63
        /// Pattern: \S+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BucketName")]
        public Union<string, IntrinsicFunction> BucketName { get; set; }

        /// <summary>
        /// BucketPrefix
        /// The bucket path that refers to the Amazon S3 bucket associated with Snowflake.
        /// Required: No
        /// Type: String
        /// Maximum: 512
        /// Pattern: . *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BucketPrefix")]
        public Union<string, IntrinsicFunction> BucketPrefix { get; set; }

        /// <summary>
        /// PrivateLinkServiceName
        /// The Snowflake Private Link service name to be used for private data transfers.
        /// Required: No
        /// Type: String
        /// Maximum: 512
        /// Pattern: \S+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PrivateLinkServiceName")]
        public Union<string, IntrinsicFunction> PrivateLinkServiceName { get; set; }

        /// <summary>
        /// AccountName
        /// The name of the account.
        /// Required: No
        /// Type: String
        /// Maximum: 512
        /// Pattern: \S+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AccountName")]
        public Union<string, IntrinsicFunction> AccountName { get; set; }

        /// <summary>
        /// Region
        /// The AWS Region of the Snowflake account.
        /// Required: No
        /// Type: String
        /// Maximum: 64
        /// Pattern: \S+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Region")]
        public Union<string, IntrinsicFunction> Region { get; set; }

    }
}
