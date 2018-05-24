using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Config.ConfigRule
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configrule-source.html
    /// </summary>
    public class Source
    {

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configrule-source.html#cfn-config-configrule-source-owner
        /// </summary>
        [JsonProperty("Owner")]
        public Union<string, IntrinsicFunction> Owner { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configrule-source.html#cfn-config-configrule-source-sourcedetails
        /// </summary>
        [JsonProperty("SourceDetails")]
        public Union<List<SourceDetail>, IntrinsicFunction> SourceDetails { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configrule-source.html#cfn-config-configrule-source-sourceidentifier
        /// </summary>
        [JsonProperty("SourceIdentifier")]
        public Union<string, IntrinsicFunction> SourceIdentifier { get; set; }

    }
}
