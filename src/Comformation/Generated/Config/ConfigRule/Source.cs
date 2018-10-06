using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Config.ConfigRule
{
    /// <summary>
    /// AWS Config ConfigRule Source
    /// Source is a property of the AWS::Config::ConfigRule resource that specifies the rule owner, the rule
    /// identifier, and the events that trigger an AWS Config evaluation of your AWS resources.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configrule-source.html
    /// </summary>
    public class Source
    {

        /// <summary>
        /// Owner
        /// Indicates who owns and manages the AWS Config rule. For valid values, see the Source data type in
        /// the AWS Config API Reference.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Owner")]
        public Union<string, IntrinsicFunction> Owner { get; set; }

        /// <summary>
        /// SourceDetails
        /// Provides the source and type of event that triggers AWS Config to evaluate your AWS resources.
        /// Required: No
        /// Type: List of AWS Config ConfigRule SourceDetails
        /// </summary>
        [JsonProperty("SourceDetails")]
        public List<SourceDetail> SourceDetails { get; set; }

        /// <summary>
        /// SourceIdentifier
        /// For AWS managed rules, the identifier of the rule. For a list of identifiers, see AWS Managed Rules
        /// in the AWS Config Developer Guide.
        /// For customer managed rules, the Amazon Resource Name (ARN) of the rule&#39;s Lambda function.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("SourceIdentifier")]
        public Union<string, IntrinsicFunction> SourceIdentifier { get; set; }

    }
}
