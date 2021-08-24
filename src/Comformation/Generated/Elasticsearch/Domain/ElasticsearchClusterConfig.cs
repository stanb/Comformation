using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Elasticsearch.Domain
{
    /// <summary>
    /// AWS::Elasticsearch::Domain ElasticsearchClusterConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticsearch-domain-elasticsearchclusterconfig.html
    /// </summary>
    public class ElasticsearchClusterConfig
    {

        /// <summary>
        /// ColdStorageOptions
        /// Specifies cold storage options for the domain.
        /// Required: No
        /// Type: ColdStorageOptions
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ColdStorageOptions")]
        public ColdStorageOptions ColdStorageOptions { get; set; }

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
        /// property. For valid values, see Supported Instance Types in the Amazon Elasticsearch Service
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
        /// Supported Instance Types in the Amazon Elasticsearch Service Developer Guide.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InstanceType")]
        public Union<string, IntrinsicFunction> InstanceType { get; set; }

        /// <summary>
        /// WarmCount
        /// The number of warm nodes in the cluster.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("WarmCount")]
        public Union<int, IntrinsicFunction> WarmCount { get; set; }

        /// <summary>
        /// WarmEnabled
        /// Whether to enable warm storage for the cluster.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("WarmEnabled")]
        public Union<bool, IntrinsicFunction> WarmEnabled { get; set; }

        /// <summary>
        /// WarmType
        /// The instance type for the cluster&#39;s warm nodes.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("WarmType")]
        public Union<string, IntrinsicFunction> WarmType { get; set; }

        /// <summary>
        /// ZoneAwarenessConfig
        /// Specifies zone awareness configuration options. Only use if ZoneAwarenessEnabled is true.
        /// Required: No
        /// Type: ZoneAwarenessConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ZoneAwarenessConfig")]
        public ZoneAwarenessConfig ZoneAwarenessConfig { get; set; }

        /// <summary>
        /// ZoneAwarenessEnabled
        /// Indicates whether to enable zone awareness for the Amazon ES domain. When you enable zone awareness,
        /// Amazon ES allocates the nodes and replica index shards that belong to a cluster across two
        /// Availability Zones (AZs) in the same region to prevent data loss and minimize downtime in the event
        /// of node or data center failure. Don&#39;t enable zone awareness if your cluster has no replica index
        /// shards or is a single-node cluster. For more information, see Configuring a Multi-AZ Domain in the
        /// Amazon Elasticsearch Service Developer Guide.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ZoneAwarenessEnabled")]
        public Union<bool, IntrinsicFunction> ZoneAwarenessEnabled { get; set; }

    }
}
