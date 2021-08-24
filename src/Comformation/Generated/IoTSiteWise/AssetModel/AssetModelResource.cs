using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTSiteWise.AssetModel
{
    /// <summary>
    /// AWS::IoTSiteWise::AssetModel
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-assetmodel.html
    /// </summary>
    public class AssetModelResource : ResourceBase
    {
        public class AssetModelProperties
        {
            /// <summary>
            /// AssetModelName
            /// A unique, friendly name for the asset model.
            /// The maximum length is 256 characters with the pattern [^\u0000-\u001F\u007F]+.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> AssetModelName { get; set; }

            /// <summary>
            /// AssetModelDescription
            /// A description for the asset model.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> AssetModelDescription { get; set; }

            /// <summary>
            /// AssetModelProperties
            /// The property definitions of the asset model. For more information, see Defining data properties in
            /// the AWS IoT SiteWise User Guide.
            /// You can specify up to 200 properties per asset model. For more information, see Quotas in the AWS
            /// IoT SiteWise User Guide.
            /// Required: No
            /// Type: List of AssetModelProperty
            /// Update requires: No interruption
            /// </summary>
            [Newtonsoft.Json.JsonProperty("AssetModelProperties")]
            public List<AssetModelProperty> AssetModelProperties_ { get; set; }

            /// <summary>
            /// AssetModelCompositeModels
            /// The composite asset models that are part of this asset model. Composite asset models are asset
            /// models that contain specific properties. Each composite model has a type that defines the properties
            /// that the composite model supports. You can use composite asset models to define alarms on this asset
            /// model.
            /// Note The alarms feature is in preview release for AWS IoT SiteWise, AWS IoT Events, and SiteWise
            /// Monitor, and is subject to change. We recommend that you use this feature only with test data, and
            /// not in production environments. For more information, see Monitoring data with alarms in the AWS IoT
            /// SiteWise User Guide.
            /// Required: No
            /// Type: List of AssetModelCompositeModel
            /// Update requires: No interruption
            /// </summary>
            public List<AssetModelCompositeModel> AssetModelCompositeModels { get; set; }

            /// <summary>
            /// AssetModelHierarchies
            /// The hierarchy definitions of the asset model. Each hierarchy specifies an asset model whose assets
            /// can be children of any other assets created from this asset model. For more information, see
            /// Defining relationships between assets in the AWS IoT SiteWiseUser Guide.
            /// You can specify up to 10 hierarchies per asset model. For more information, see Quotas in the AWS
            /// IoT SiteWise User Guide.
            /// Required: No
            /// Type: List of AssetModelHierarchy
            /// Update requires: No interruption
            /// </summary>
            public List<AssetModelHierarchy> AssetModelHierarchies { get; set; }

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

        public string Type { get; } = "AWS::IoTSiteWise::AssetModel";

        public AssetModelProperties Properties { get; } = new AssetModelProperties();

    }

    public static class AssetModelAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> AssetModelId = new ResourceAttribute<Union<string, IntrinsicFunction>>("AssetModelId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> AssetModelArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("AssetModelArn");
    }
}
