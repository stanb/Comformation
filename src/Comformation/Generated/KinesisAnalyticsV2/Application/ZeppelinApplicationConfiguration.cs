using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalyticsV2.Application
{
    /// <summary>
    /// AWS::KinesisAnalyticsV2::Application ZeppelinApplicationConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-zeppelinapplicationconfiguration.html
    /// </summary>
    public class ZeppelinApplicationConfiguration
    {

        /// <summary>
        /// CatalogConfiguration
        /// The Amazon Glue Data Catalog that you use in queries in a Kinesis Data Analytics Studio notebook.
        /// Required: No
        /// Type: CatalogConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CatalogConfiguration")]
        public CatalogConfiguration CatalogConfiguration { get; set; }

        /// <summary>
        /// MonitoringConfiguration
        /// The monitoring configuration of a Kinesis Data Analytics Studio notebook.
        /// Required: No
        /// Type: ZeppelinMonitoringConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MonitoringConfiguration")]
        public ZeppelinMonitoringConfiguration MonitoringConfiguration { get; set; }

        /// <summary>
        /// DeployAsApplicationConfiguration
        /// The information required to deploy a Kinesis Data Analytics Studio notebook as an application with
        /// durable state.
        /// Required: No
        /// Type: DeployAsApplicationConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DeployAsApplicationConfiguration")]
        public DeployAsApplicationConfiguration DeployAsApplicationConfiguration { get; set; }

        /// <summary>
        /// CustomArtifactsConfiguration
        /// A list of CustomArtifactConfiguration objects.
        /// Required: No
        /// Type: CustomArtifactsConfiguration
        /// Maximum: 50
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CustomArtifactsConfiguration")]
        public List<CustomArtifactConfiguration> CustomArtifactsConfiguration { get; set; }

    }
}
