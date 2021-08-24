using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Elasticsearch.Domain
{
    /// <summary>
    /// AWS::Elasticsearch::Domain
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticsearch-domain.html
    /// </summary>
    public class DomainResource : ResourceBase
    {
        public class DomainProperties
        {
            /// <summary>
            /// AccessPolicies
            /// An AWS Identity and Access Management (IAM) policy document that specifies who can access the Amazon
            /// ES domain and their permissions. For more information, see Configuring Access Policies in the Amazon
            /// Elasticsearch Service Developer Guide.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> AccessPolicies { get; set; }

            /// <summary>
            /// AdvancedOptions
            /// Additional options to specify for the Amazon ES domain. For more information, see Configuring
            /// Advanced Options in the Amazon Elasticsearch Service Developer Guide.
            /// Required: No
            /// Type: Map of String
            /// Update requires: No interruption
            /// </summary>
            public Dictionary<string, Union<string, IntrinsicFunction>> AdvancedOptions { get; set; }

            /// <summary>
            /// AdvancedSecurityOptions
            /// Specifies options for fine-grained access control.
            /// Required: No
            /// Type: AdvancedSecurityOptionsInput
            /// Update requires: Replacement
            /// </summary>
            public AdvancedSecurityOptionsInput AdvancedSecurityOptions { get; set; }

            /// <summary>
            /// CognitoOptions
            /// Configures Amazon ES to use Amazon Cognito authentication for Kibana.
            /// Required: No
            /// Type: CognitoOptions
            /// Update requires: No interruption
            /// </summary>
            public CognitoOptions CognitoOptions { get; set; }

            /// <summary>
            /// DomainEndpointOptions
            /// Specifies additional options for the domain endpoint, such as whether to require HTTPS for all
            /// traffic or whether to use a custom endpoint rather than the default endpoint.
            /// Required: No
            /// Type: DomainEndpointOptions
            /// Update requires: No interruption
            /// </summary>
            public DomainEndpointOptions DomainEndpointOptions { get; set; }

            /// <summary>
            /// DomainName
            /// A name for the Amazon ES domain. For valid values, see the DomainName data type in the Amazon
            /// Elasticsearch Service Developer Guide. If you don&#39;t specify a name, AWS CloudFormation generates a
            /// unique physical ID and uses that ID for the domain name. For more information, see Name Type.
            /// Important If you specify a name, you cannot perform updates that require replacement of this
            /// resource. You can perform updates that require no or some interruption. If you must replace the
            /// resource, specify a new name.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DomainName { get; set; }

            /// <summary>
            /// EBSOptions
            /// The configurations of Amazon Elastic Block Store (Amazon EBS) volumes that are attached to data
            /// nodes in the Amazon ES domain. For more information, see Configuring EBS-based Storage in the Amazon
            /// Elasticsearch Service Developer Guide.
            /// Required: No
            /// Type: EBSOptions
            /// Update requires: No interruption
            /// </summary>
            public EBSOptions EBSOptions { get; set; }

            /// <summary>
            /// ElasticsearchClusterConfig
            /// ElasticsearchClusterConfig is a property of the AWS::Elasticsearch::Domain resource that configures
            /// the cluster of an Amazon Elasticsearch Service (Amazon ES) domain.
            /// Required: No
            /// Type: ElasticsearchClusterConfig
            /// Update requires: No interruption
            /// </summary>
            public ElasticsearchClusterConfig ElasticsearchClusterConfig { get; set; }

            /// <summary>
            /// ElasticsearchVersion
            /// The version of Elasticsearch to use, such as 2. 3. If not specified, 1. 5 is used as the default.
            /// For information about the versions that Amazon ES supports, see the Elasticsearch-Version parameter
            /// for the CreateElasticsearchDomain action in the Amazon Elasticsearch Service Developer Guide.
            /// If you set the UpgradeElasticsearchVersion update policy to true, you can update
            /// ElasticsearchVersion without interruption. When UpgradeElasticsearchVersion is set to false, or is
            /// not specified, updating ElasticsearchVersion results in replacement.
            /// Required: No
            /// Type: String
            /// Update requires: Some interruptions
            /// </summary>
            public Union<string, IntrinsicFunction> ElasticsearchVersion { get; set; }

            /// <summary>
            /// EncryptionAtRestOptions
            /// Whether the domain should encrypt data at rest, and if so, the AWS Key Management Service key to
            /// use.
            /// Required: No
            /// Type: EncryptionAtRestOptions
            /// Update requires: Some interruptions
            /// </summary>
            public EncryptionAtRestOptions EncryptionAtRestOptions { get; set; }

            /// <summary>
            /// LogPublishingOptions
            /// An object with one or more of the following keys: SEARCH_SLOW_LOGS, ES_APPLICATION_LOGS,
            /// INDEX_SLOW_LOGS, AUDIT_LOGS, depending on the types of logs you want to publish. Each key needs a
            /// valid LogPublishingOption value. See here for the full syntax.
            /// Required: No
            /// Type: Map of LogPublishingOption
            /// Update requires: No interruption
            /// </summary>
            public Dictionary<string, LogPublishingOption> LogPublishingOptions { get; set; }

            /// <summary>
            /// NodeToNodeEncryptionOptions
            /// Specifies whether node-to-node encryption is enabled.
            /// Required: No
            /// Type: NodeToNodeEncryptionOptions
            /// Update requires: Some interruptions
            /// </summary>
            public NodeToNodeEncryptionOptions NodeToNodeEncryptionOptions { get; set; }

            /// <summary>
            /// SnapshotOptions
            /// DEPRECATED. The automated snapshot configuration for the Amazon ES domain indices.
            /// Required: No
            /// Type: SnapshotOptions
            /// Update requires: No interruption
            /// </summary>
            public SnapshotOptions SnapshotOptions { get; set; }

            /// <summary>
            /// Tags
            /// An arbitrary set of tags (key–value pairs) to associate with the Amazon ES domain.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// VPCOptions
            /// The virtual private cloud (VPC) configuration for the Amazon ES domain. For more information, see
            /// VPC Support for Amazon Elasticsearch Service Domains in the Amazon Elasticsearch Service Developer
            /// Guide.
            /// Required: No
            /// Type: VPCOptions
            /// Update requires: No interruption
            /// </summary>
            public VPCOptions VPCOptions { get; set; }

        }

        public string Type { get; } = "AWS::Elasticsearch::Domain";

        public DomainProperties Properties { get; } = new DomainProperties();

    }

    public static class DomainAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> DomainArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("DomainArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> DomainEndpoint = new ResourceAttribute<Union<string, IntrinsicFunction>>("DomainEndpoint");
    }
}
