using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTSiteWise.AssetModel
{
    /// <summary>
    /// AWS::IoTSiteWise::AssetModel AssetModelCompositeModel
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-assetmodel-assetmodelcompositemodel.html
    /// </summary>
    public class AssetModelCompositeModel
    {

        /// <summary>
        /// Description
        /// The description of the composite model.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Description")]
        public Union<string, IntrinsicFunction> Description { get; set; }

        /// <summary>
        /// Name
        /// The name of the composite model.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// Type
        /// The type of the composite model. For alarm composite models, this type is AWS/ALARM.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// CompositeModelProperties
        /// The asset property definitions for this composite model.
        /// Required: No
        /// Type: List of AssetModelProperty
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CompositeModelProperties")]
        public List<AssetModelProperty> CompositeModelProperties { get; set; }

    }
}
