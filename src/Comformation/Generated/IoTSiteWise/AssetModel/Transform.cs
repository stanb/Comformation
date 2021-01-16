using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTSiteWise.AssetModel
{
    /// <summary>
    /// AWS::IoTSiteWise::AssetModel Transform
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-assetmodel-transform.html
    /// </summary>
    public class Transform
    {

        /// <summary>
        /// Expression
        /// The mathematical expression that defines the transformation function. You can specify up to 10
        /// variables per expression. You can specify up to 10 functions per expression.
        /// For more information, see Quotas in the AWS IoT SiteWise User Guide.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Expression")]
        public Union<string, IntrinsicFunction> Expression { get; set; }

        /// <summary>
        /// Variables
        /// The list of variables used in the expression.
        /// Required: Yes
        /// Type: List of ExpressionVariable
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Variables")]
        public List<ExpressionVariable> Variables { get; set; }

    }
}
