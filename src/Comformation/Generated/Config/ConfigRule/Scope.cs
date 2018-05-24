using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Config.ConfigRule
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configrule-scope.html
    /// </summary>
    public class Scope
    {

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configrule-scope.html#cfn-config-configrule-scope-complianceresourceid
        /// </summary>
        [JsonProperty("ComplianceResourceId")]
        public Union<string, IntrinsicFunction> ComplianceResourceId { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configrule-scope.html#cfn-config-configrule-scope-complianceresourcetypes
        /// </summary>
        [JsonProperty("ComplianceResourceTypes")]
        public Union<List<string>, IntrinsicFunction> ComplianceResourceTypes { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configrule-scope.html#cfn-config-configrule-scope-tagkey
        /// </summary>
        [JsonProperty("TagKey")]
        public Union<string, IntrinsicFunction> TagKey { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configrule-scope.html#cfn-config-configrule-scope-tagvalue
        /// </summary>
        [JsonProperty("TagValue")]
        public Union<string, IntrinsicFunction> TagValue { get; set; }

    }
}
