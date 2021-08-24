using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.Dashboard
{
    /// <summary>
    /// AWS::QuickSight::Dashboard ResourcePermission
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-resourcepermission.html
    /// </summary>
    public class ResourcePermission
    {

        /// <summary>
        /// Actions
        /// The IAMaction to grant or revoke permissions on.
        /// Required: Yes
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Actions")]
        public List<Union<string, IntrinsicFunction>> Actions { get; set; }

        /// <summary>
        /// Principal
        /// The Amazon Resource Name (ARN) of the principal. This can be one of the following:
        /// The ARN of an Amazon QuickSight user or group associated with a data source or dataset. (This is
        /// common. ) The ARN of an Amazon QuickSight user, group, or namespace associated with an analysis,
        /// dashboard, template, or theme. (This is common. ) The ARN of an AWS account root: This is an IAMARN
        /// rather than a Amazon QuickSightARN. Use this option only to share resources (templates) across AWS
        /// accounts. (This is less common. )
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Principal")]
        public Union<string, IntrinsicFunction> Principal { get; set; }

    }
}
