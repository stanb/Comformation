using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTSiteWise.AssetModel
{
    /// <summary>
    /// AWS::IoTSiteWise::AssetModel AssetModelHierarchy
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-assetmodel-assetmodelhierarchy.html
    /// </summary>
    public class AssetModelHierarchy
    {

        /// <summary>
        /// LogicalId
        /// The LogicalID of the asset model hierarchy. This ID is a hierarchyLogicalId.
        /// The maximum length is 256 characters, with the pattern [^\u0000-\u001F\u007F]+
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LogicalId")]
        public Union<string, IntrinsicFunction> LogicalId { get; set; }

        /// <summary>
        /// Name
        /// The name of the asset model hierarchy.
        /// The maximum length is 256 characters with the pattern [^\u0000-\u001F\u007F]+.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// ChildAssetModelId
        /// The Id of the asset model.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ChildAssetModelId")]
        public Union<string, IntrinsicFunction> ChildAssetModelId { get; set; }

    }
}
