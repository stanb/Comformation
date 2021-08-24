using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.Dashboard
{
    /// <summary>
    /// AWS::QuickSight::Dashboard DashboardSourceTemplate
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboardsourcetemplate.html
    /// </summary>
    public class DashboardSourceTemplate
    {

        /// <summary>
        /// DataSetReferences
        /// Dataset references.
        /// Required: Yes
        /// Type: List of DataSetReference
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DataSetReferences")]
        public List<DataSetReference> DataSetReferences { get; set; }

        /// <summary>
        /// Arn
        /// The Amazon Resource Name (ARN) of the resource.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Arn")]
        public Union<string, IntrinsicFunction> Arn { get; set; }

    }
}
