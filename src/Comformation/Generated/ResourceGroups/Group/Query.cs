using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ResourceGroups.Group
{
    /// <summary>
    /// AWS::ResourceGroups::Group Query
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resourcegroups-group-query.html
    /// </summary>
    public class Query
    {

        /// <summary>
        /// ResourceTypeFilters
        /// Specifies limits to the types of resources that can be included in the resource group. For example,
        /// if ResourceTypeFilters is [&quot;AWS::EC2::Instance&quot;, &quot;AWS::DynamoDB::Table&quot;], only EC2 instances or
        /// DynamoDB tables can be members of this resource group. The default value is [&quot;AWS::AllSupported&quot;].
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ResourceTypeFilters")]
        public List<Union<string, IntrinsicFunction>> ResourceTypeFilters { get; set; }

        /// <summary>
        /// StackIdentifier
        /// Specifies the ARN of a CloudFormation stack. All supported resources of the CloudFormation stack are
        /// members of the resource group. If you don&#39;t specify an ARN, this parameter defaults to the current
        /// stack that you are defining, which means that all the resources of the current stack are grouped.
        /// You can specify a value for StackIdentifier only when the ResourceQuery. Type property is
        /// CLOUDFORMATION_STACK_1_0.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StackIdentifier")]
        public Union<string, IntrinsicFunction> StackIdentifier { get; set; }

        /// <summary>
        /// TagFilters
        /// A list of key-value pair objects that limit which resources can be members of the resource group.
        /// This property is required when the ResourceQuery. Type property is TAG_FILTERS_1_0.
        /// A resource must have a tag that matches every filter that is provided in the TagFilters list.
        /// Required: Conditional
        /// Type: List of TagFilter
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TagFilters")]
        public List<TagFilter> TagFilters { get; set; }

    }
}
