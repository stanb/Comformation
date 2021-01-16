using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTSiteWise.Asset
{
    /// <summary>
    /// AWS::IoTSiteWise::Asset
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-asset.html
    /// </summary>
    public class AssetResource : ResourceBase
    {
        public class AssetProperties
        {
            /// <summary>
            /// AssetModelId
            /// The ID of the asset model from which to create the asset.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> AssetModelId { get; set; }

            /// <summary>
            /// AssetName
            /// A unique, friendly name for the asset.
            /// The maximum length is 256 characters with the pattern [^\u0000-\u001F\u007F]+.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> AssetName { get; set; }

            /// <summary>
            /// AssetProperties
            /// The list of asset properties for the asset.
            /// This object doesn&#39;t include properties that you define in composite models. You can find composite
            /// model properties in the assetCompositeModels object.
            /// Required: No
            /// Type: List of AssetProperty
            /// Update requires: No interruption
            /// </summary>
            [Newtonsoft.Json.JsonProperty("AssetProperties")]
            public List<AssetProperty> AssetProperties_ { get; set; }

            /// <summary>
            /// AssetHierarchies
            /// A list of asset hierarchies that each contain a hierarchyLogicalId. A hierarchy specifies allowed
            /// parent/child asset relationships.
            /// Required: No
            /// Type: List of AssetHierarchy
            /// Update requires: No interruption
            /// </summary>
            public List<AssetHierarchy> AssetHierarchies { get; set; }

            /// <summary>
            /// Tags
            /// A list of key-value pairs that contain metadata for the asset. For more information, see Tagging
            /// your AWS IoT SiteWise resources in the AWS IoT SiteWise User Guide.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::IoTSiteWise::Asset";

        public AssetProperties Properties { get; } = new AssetProperties();

    }

    public static class AssetAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> AssetId = new ResourceAttribute<Union<string, IntrinsicFunction>>("AssetId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> AssetArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("AssetArn");
    }
}
