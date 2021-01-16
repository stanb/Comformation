using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ResourceGroups.Group
{
    /// <summary>
    /// AWS::ResourceGroups::Group ResourceQuery
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resourcegroups-group-resourcequery.html
    /// </summary>
    public class ResourceQuery
    {

        /// <summary>
        /// Type
        /// The valid types are TAG_FILTERS_1_0 and CLOUDFORMATION_STACK_1_0. Each type requires specific
        /// attributes for the Query object:
        /// TAG_FILTERS_1_0 indicates that the group is a tag-based group. Group membership is defined by the
        /// query&#39;s TagFilters property. Specify the tag filters to use in the query. CLOUDFORMATION_STACK_1_0,
        /// the default, indicates that the group is a CloudFormation stack-based group. Group membership is
        /// based on the CloudFormation stack. Specify the StackIdentifier property in the query to define which
        /// stack to associate the group with, or leave it empty to default to the stack where the group is
        /// defined.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// Query
        /// The query that defines a group. This field is required when the type is TAG_FILTERS_1_0.
        /// Required: Conditional
        /// Type: Query
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Query")]
        public Query Query { get; set; }

    }
}
