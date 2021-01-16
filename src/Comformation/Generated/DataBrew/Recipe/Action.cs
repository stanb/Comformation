using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DataBrew.Recipe
{
    /// <summary>
    /// AWS::DataBrew::Recipe Action
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-action.html
    /// </summary>
    public class Action
    {

        /// <summary>
        /// Operation
        /// The name of a valid DataBrew transformation to be performed on the data.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Operation")]
        public Union<string, IntrinsicFunction> Operation { get; set; }

    }
}
