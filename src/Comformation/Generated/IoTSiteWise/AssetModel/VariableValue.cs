using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTSiteWise.AssetModel
{
    /// <summary>
    /// AWS::IoTSiteWise::AssetModel VariableValue
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-assetmodel-variablevalue.html
    /// </summary>
    public class VariableValue
    {

        /// <summary>
        /// PropertyLogicalId
        /// The LogicalID of the property to use as the variable.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PropertyLogicalId")]
        public Union<string, IntrinsicFunction> PropertyLogicalId { get; set; }

        /// <summary>
        /// HierarchyLogicalId
        /// The LogicalID of the hierarchy to query for the PropertyLogicalID.
        /// You use a hierarchyLogicalID instead of a model ID because you can have several hierarchies using
        /// the same model and therefore the same property. For example, you might have separately grouped
        /// assets that come from the same asset model. For more information, see Defining relationships between
        /// assets in the AWS IoT SiteWise User Guide.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HierarchyLogicalId")]
        public Union<string, IntrinsicFunction> HierarchyLogicalId { get; set; }

    }
}
