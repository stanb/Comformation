using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTSiteWise.AssetModel
{
    /// <summary>
    /// AWS::IoTSiteWise::AssetModel Attribute
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-assetmodel-attribute.html
    /// </summary>
    public class Attribute
    {

        /// <summary>
        /// DefaultValue
        /// The default value of the asset model property attribute. All assets that you create from the asset
        /// model contain this attribute value. You can update an attribute&#39;s value after you create an asset.
        /// For more information, see Updating attribute values in the AWS IoT SiteWise User Guide.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DefaultValue")]
        public Union<string, IntrinsicFunction> DefaultValue { get; set; }

    }
}
