using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSM.PatchBaseline
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-patchbaseline-rule.html
    /// </summary>
    public class Rule
    {

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-patchbaseline-rule.html#cfn-ssm-patchbaseline-rule-enablenonsecurity
        /// </summary>
        [JsonProperty("EnableNonSecurity")]
        public Union<bool?, IntrinsicFunction> EnableNonSecurity { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-patchbaseline-rule.html#cfn-ssm-patchbaseline-rule-patchfiltergroup
        /// </summary>
        [JsonProperty("PatchFilterGroup")]
        public Union<PatchFilterGroup, IntrinsicFunction> PatchFilterGroup { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-patchbaseline-rule.html#cfn-ssm-patchbaseline-rule-approveafterdays
        /// </summary>
        [JsonProperty("ApproveAfterDays")]
        public Union<int?, IntrinsicFunction> ApproveAfterDays { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-patchbaseline-rule.html#cfn-ssm-patchbaseline-rule-compliancelevel
        /// </summary>
        [JsonProperty("ComplianceLevel")]
        public Union<string, IntrinsicFunction> ComplianceLevel { get; set; }

    }
}
