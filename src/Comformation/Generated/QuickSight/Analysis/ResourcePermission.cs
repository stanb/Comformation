using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.Analysis
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-resourcepermission.html
    /// </summary>
    public class ResourcePermission
    {

        /// <summary>
        /// Actions
        /// </summary>
        [JsonProperty("Actions")]
        public List<Union<string, IntrinsicFunction>> Actions { get; set; }

        /// <summary>
        /// Principal
        /// </summary>
        [JsonProperty("Principal")]
        public Union<string, IntrinsicFunction> Principal { get; set; }

    }
}
