using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTSiteWise.Asset
{
    /// <summary>
    /// AWS::IoTSiteWise::Asset AssetHierarchy
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-asset-assethierarchy.html
    /// </summary>
    public class AssetHierarchy
    {

        /// <summary>
        /// LogicalId
        /// The LogicalID of the hierarchy. This ID is a hierarchyLogicalId.
        /// The maximum length is 256 characters, with the pattern [^\u0000-\u001F\u007F]+.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LogicalId")]
        public Union<string, IntrinsicFunction> LogicalId { get; set; }

        /// <summary>
        /// ChildAssetId
        /// The Id of the child asset.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ChildAssetId")]
        public Union<string, IntrinsicFunction> ChildAssetId { get; set; }

    }
}
