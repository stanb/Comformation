using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Elasticsearch.Domain
{
    /// <summary>
    /// AWS::Elasticsearch::Domain
    /// The AWS::Elasticsearch::Domain resource creates an Amazon Elasticsearch Service (Amazon ES) domain that
    /// encapsulates the Amazon ES engine instances. For more information, see CreateElasticsearchDomain in the Amazon
    /// Elasticsearch Service Developer Guide.
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
            /// Type: JSON object
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> AccessPolicies { get; set; }

            /// <summary>
            /// AdvancedOptions
            /// Additional options to specify for the Amazon ES domain. For more information, see Configuring
            /// Advanced Options in the Amazon Elasticsearch Service Developer Guide.
            /// Required: No
            /// Type: A JSON object that consists of a string key-value pair, such as:
            /// { "rest. action. multi. allow_explicit_index": "true" }
            /// Update requires: Replacement
            /// </summary>
			public Union<Dictionary<string, string>, IntrinsicFunction> AdvancedOptions { get; set; }

            /// <summary>
            /// DomainName
            /// A name for the Amazon ES domain. For valid values, see the DomainName data type in the Amazon
            /// Elasticsearch Service Developer Guide.
            /// If you don't specify a name, AWS CloudFormation generates a unique physical ID and uses that ID for
            /// the domain name. For more information, see Name Type.
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
            /// Type: Amazon ES Domain EBSOptions
            /// Update requires: No interruption
            /// </summary>
			public Union<EBSOptions, IntrinsicFunction> EBSOptions { get; set; }

            /// <summary>
            /// ElasticsearchClusterConfig
            /// The cluster configuration for the Amazon ES domain. You can specify options such as the instance
            /// type and the number of instances. For more information, see Configuring Amazon ES Domains in the
            /// Amazon Elasticsearch Service Developer Guide.
            /// Required: No
            /// Type: Amazon ES Domain ElasticsearchClusterConfig
            /// Update requires: No interruption
            /// </summary>
			public Union<ElasticsearchClusterConfig, IntrinsicFunction> ElasticsearchClusterConfig { get; set; }

            /// <summary>
            /// ElasticsearchVersion
            /// The version of Elasticsearch to use, such as 2. 3. For information about the versions that Amazon ES
            /// supports, see the Elasticsearch-Version parameter for the CreateElasticsearchDomain action in the
            /// Amazon Elasticsearch Service Developer Guide.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ElasticsearchVersion { get; set; }

            /// <summary>
            /// EncryptionAtRestOptions
            /// Whether the domain should encrypt data at rest, and if so, the AWS Key Management Service (KMS) key
            /// to use. Can only be used to create a new domain, not update an existing one.
            /// Required: No
            /// Type: Amazon ES Domain EncryptionAtRestOptions
            /// Update requires: Replacement
            /// </summary>
			public Union<EncryptionAtRestOptions, IntrinsicFunction> EncryptionAtRestOptions { get; set; }

            /// <summary>
            /// SnapshotOptions
            /// The automated snapshot configuration for the Amazon ES domain indices.
            /// Required: No
            /// Type: Amazon ES Domain SnapshotOptions
            /// Update requires: No interruption
            /// </summary>
			public Union<SnapshotOptions, IntrinsicFunction> SnapshotOptions { get; set; }

            /// <summary>
            /// Tags
            /// An arbitrary set of tags (key–value pairs) to associate with the Amazon ES domain.
            /// Required: No
            /// Type: AWS CloudFormation Resource Tags
            /// Update requires: No interruption
            /// </summary>
			public Union<List<Tag>, IntrinsicFunction> Tags { get; set; }

            /// <summary>
            /// VPCOptions
            /// The virtual private cloud (VPC) configuration for the Amazon ES domain. For more information, see
            /// VPC Support for Amazon Elasticsearch Service Domains in the Amazon Elasticsearch Service Developer
            /// Guide.
            /// Required: No
            /// Type: Amazon ES Domain VPCOptions
            /// Update requires: No interruption
            /// </summary>
			public Union<VPCOptions, IntrinsicFunction> VPCOptions { get; set; }

        }
    
        public string Type { get; } = "AWS::Elasticsearch::Domain";
        
        public DomainProperties Properties { get; } = new DomainProperties();
    }

	public static class DomainAttributes
	{
        public static readonly ResourceAttribute<string> Arn = new ResourceAttribute<string>("Arn");
        public static readonly ResourceAttribute<string> DomainArn = new ResourceAttribute<string>("DomainArn");
        public static readonly ResourceAttribute<string> DomainEndpoint = new ResourceAttribute<string>("DomainEndpoint");
	}
}
