using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Elasticsearch.Domain
{
    /// <summary>
    /// AWS::Elasticsearch::Domain ElasticsearchClusterConfig
    /// The cluster configuration for the Amazon ES domain. You can specify options such as the instance type and the
    /// number of instances. For more information, see Configuring Amazon ES Domains in the Amazon Elasticsearch
    /// Service Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticsearch-domain-elasticsearchclusterconfig.html
    /// </summary>
    public class ElasticsearchClusterConfig
    {

        /// <summary>
        /// DedicatedMasterCount
        /// The number of instances to use for the master node. If you specify this property, you must specify
        /// true for the DedicatedMasterEnabled property.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DedicatedMasterCount")]
        public Union<int, IntrinsicFunction> DedicatedMasterCount { get; set; }

        /// <summary>
        /// DedicatedMasterEnabled
        /// Indicates whether to use a dedicated master node for the Amazon ES domain. A dedicated master node
        /// is a cluster node that performs cluster management tasks, but doesn&#39;t hold data or respond to data
        /// upload requests. Dedicated master nodes offload cluster management tasks to increase the stability
        /// of your search clusters.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DedicatedMasterEnabled")]
        public Union<bool, IntrinsicFunction> DedicatedMasterEnabled { get; set; }

        /// <summary>
        /// DedicatedMasterType
        /// The hardware configuration of the computer that hosts the dedicated master node, such as m3. medium.
        /// elasticsearch. If you specify this property, you must specify true for the DedicatedMasterEnabled
        /// property. For valid values, see Configuring Amazon ES Domains in the Amazon Elasticsearch Service
        /// Developer Guide.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DedicatedMasterType")]
        public Union<string, IntrinsicFunction> DedicatedMasterType { get; set; }

        /// <summary>
        /// InstanceCount
        /// The number of data nodes (instances) to use in the Amazon ES domain.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InstanceCount")]
        public Union<int, IntrinsicFunction> InstanceCount { get; set; }

        /// <summary>
        /// InstanceType
        /// The instance type for your data nodes, such as m3. medium. elasticsearch. For valid values, see
        /// Configuring Amazon ES Domains in the Amazon Elasticsearch Service Developer Guide.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InstanceType")]
        public Union<string, IntrinsicFunction> InstanceType { get; set; }

        /// <summary>
        /// ZoneAwarenessEnabled
        /// Indicates whether to enable zone awareness for the Amazon ES domain. When you enable zone awareness,
        /// Amazon ES allocates the nodes and replica index shards that belong to a cluster across two
        /// Availability Zones (AZs) in the same region to prevent data loss and minimize downtime in the event
        /// of node or data center failure. Don&#39;t enable zone awareness if your cluster has no replica index
        /// shards or is a single-node cluster. For more information, see Enabling Zone Awareness in the Amazon
        /// Elasticsearch Service Developer Guide.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ZoneAwarenessEnabled")]
        public Union<bool, IntrinsicFunction> ZoneAwarenessEnabled { get; set; }

    }
}
