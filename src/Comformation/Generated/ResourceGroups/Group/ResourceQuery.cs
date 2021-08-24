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
        /// Specifies the type of resource query that determines this group&#39;s membership. There are two valid
        /// query types:
        /// TAG_FILTERS_1_0 indicates that the group is a tag-based group. To complete the group membership, you
        /// must include the TagFilters property to specify the tag filters to use in the query.
        /// CLOUDFORMATION_STACK_1_0, the default, indicates that the group is a CloudFormation stack-based
        /// group. Group membership is based on the CloudFormation stack. You must specify the StackIdentifier
        /// property in the query to define which stack to associate the group with, or leave it empty to
        /// default to the stack where the group is defined.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// Query
        /// The query that defines the membership of the group. This is a structure with properties that depend
        /// on the Type.
        /// The Query structure must be included in the following scenarios:
        /// When the Type is TAG_FILTERS_1_0, you must specify a Query structure that contains a TagFilters list
        /// of tags. Resources with tags that match those in the TagFilter list become members of the resource
        /// group. When the Type is CLOUDFORMATION_STACK_1_0 then this field is required only when you must
        /// specify a CloudFormation stack other than the one you are defining. To do this, the Query structure
        /// must contain the StackIdentifier property. If you don&#39;t specify either a Query structure or a
        /// StackIdentifier within that Query, then it defaults to the CloudFormation stack that you&#39;re
        /// currently constructing.
        /// Required: No
        /// Type: Query
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Query")]
        public Query Query { get; set; }

    }
}
