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
        /// The resource types that can be part of the resource group. For example, if ResourceTypeFilters is
        /// [&quot;AWS::EC2::Instance&quot;, &quot;AWS::DynamoDB::Table&quot;], only EC2 Instance resources or DynamoDB Table
        /// resources can be members of this resource group. The default value is [&quot;AWS::AllSupported&quot;].
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ResourceTypeFilters")]
        public List<Union<string, IntrinsicFunction>> ResourceTypeFilters { get; set; }

        /// <summary>
        /// StackIdentifier
        /// The CFN Stack ARN. When specified, all supported resources of the CFN stack are members of the
        /// resource group. The default value is an identifier of the current stack, which means that all the
        /// resources of the current stack are grouped.
        /// Only specify a value for StackIdentifier when the ResourceQuery. Type property is
        /// CLOUDFORMATION_STACK_1_0.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StackIdentifier")]
        public Union<string, IntrinsicFunction> StackIdentifier { get; set; }

        /// <summary>
        /// TagFilters
        /// A list of key-value pair objects that limit which resources are members of a group. This property is
        /// required when the ResourceQuery. Type property is TAG_FILTERS_1_0.
        /// TagFilter objects include two properties: Key (a string) and Values (a list of strings). Only
        /// resources in the account that are tagged with an allowed key-value pair are members of the group.
        /// The Values property of TagFilter is optional, but specifying it narrows the query results. For
        /// example, suppose TagFilters is [{&quot;Key&quot;: &quot;Stage&quot;, &quot;Values&quot;: [&quot;Test&quot;, &quot;Beta&quot;]}, {&quot;Key&quot;: &quot;Storage&quot;}].
        /// In this case, only resources with all of the following tags are members of the group:
        /// Stage tag key with a value of either Test or Beta Storage tag key with any value
        /// Required: Conditional
        /// Type: List of TagFilter
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TagFilters")]
        public List<TagFilter> TagFilters { get; set; }

    }
}
