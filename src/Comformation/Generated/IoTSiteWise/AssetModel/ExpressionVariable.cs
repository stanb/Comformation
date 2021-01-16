using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTSiteWise.AssetModel
{
    /// <summary>
    /// AWS::IoTSiteWise::AssetModel ExpressionVariable
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-assetmodel-expressionvariable.html
    /// </summary>
    public class ExpressionVariable
    {

        /// <summary>
        /// Name
        /// The friendly name of the variable to be used in the expression.
        /// The maximum length is 64 characters with the pattern ^[a-z][a-z0-9_]*$.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// Value
        /// The variable that identifies an asset property from which to use values.
        /// Required: Yes
        /// Type: VariableValue
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Value")]
        public VariableValue Value { get; set; }

    }
}
