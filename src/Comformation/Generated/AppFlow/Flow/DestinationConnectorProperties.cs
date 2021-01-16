using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppFlow.Flow
{
    /// <summary>
    /// AWS::AppFlow::Flow DestinationConnectorProperties
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-destinationconnectorproperties.html
    /// </summary>
    public class DestinationConnectorProperties
    {

        /// <summary>
        /// Redshift
        /// The properties required to query Amazon Redshift.
        /// Required: No
        /// Type: RedshiftDestinationProperties
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Redshift")]
        public RedshiftDestinationProperties Redshift { get; set; }

        /// <summary>
        /// S3
        /// The properties required to query Amazon S3.
        /// Required: No
        /// Type: S3DestinationProperties
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3")]
        public S3DestinationProperties S3 { get; set; }

        /// <summary>
        /// Salesforce
        /// The properties required to query Salesforce.
        /// Required: No
        /// Type: SalesforceDestinationProperties
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Salesforce")]
        public SalesforceDestinationProperties Salesforce { get; set; }

        /// <summary>
        /// Snowflake
        /// The properties required to query Snowflake.
        /// Required: No
        /// Type: SnowflakeDestinationProperties
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Snowflake")]
        public SnowflakeDestinationProperties Snowflake { get; set; }

        /// <summary>
        /// EventBridge
        /// The properties required to query Amazon EventBridge.
        /// Required: No
        /// Type: EventBridgeDestinationProperties
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EventBridge")]
        public EventBridgeDestinationProperties EventBridge { get; set; }

        /// <summary>
        /// Upsolver
        /// The properties required to query Upsolver.
        /// Required: No
        /// Type: UpsolverDestinationProperties
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Upsolver")]
        public UpsolverDestinationProperties Upsolver { get; set; }

    }
}
