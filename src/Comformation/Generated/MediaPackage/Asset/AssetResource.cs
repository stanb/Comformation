using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaPackage.Asset
{
    /// <summary>
    /// AWS::MediaPackage::Asset
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackage-asset.html
    /// </summary>
    public class AssetResource : ResourceBase
    {
        public class AssetProperties
        {
            /// <summary>
            /// Id
            /// Unique identifier that you assign to the asset.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Id { get; set; }

            /// <summary>
            /// PackagingGroupId
            /// The ID of the packaging group associated with this asset.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> PackagingGroupId { get; set; }

            /// <summary>
            /// ResourceId
            /// Unique identifier for this asset, as it&#39;s configured in the key provider service.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ResourceId { get; set; }

            /// <summary>
            /// SourceArn
            /// The ARN for the source content in Amazon S3.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> SourceArn { get; set; }

            /// <summary>
            /// SourceRoleArn
            /// The ARN for the IAM role that provides AWS Elemental MediaPackage access to the Amazon S3 bucket
            /// where the source content is stored. Valid format: arn:aws:iam::{accountID}:role/{name}
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> SourceRoleArn { get; set; }

            /// <summary>
            /// Tags
            /// The tags to assign to the asset.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::MediaPackage::Asset";

        public AssetProperties Properties { get; } = new AssetProperties();

    }

    public static class AssetAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CreatedAt = new ResourceAttribute<Union<string, IntrinsicFunction>>("CreatedAt");
        public static readonly ResourceAttribute<List<EgressEndpoint>> EgressEndpoints = new ResourceAttribute<List<EgressEndpoint>>("EgressEndpoints");
    }
}
