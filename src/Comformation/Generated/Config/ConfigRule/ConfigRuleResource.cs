using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Config.ConfigRule
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-configrule.html
    /// </summary>
    public class ConfigRuleResource : ResourceBase
    {
        public class ConfigRuleProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-configrule.html#cfn-config-configrule-configrulename
            /// </summary>
			public Union<string, IntrinsicFunction> ConfigRuleName { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-configrule.html#cfn-config-configrule-description
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-configrule.html#cfn-config-configrule-inputparameters
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> InputParameters { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-configrule.html#cfn-config-configrule-maximumexecutionfrequency
            /// </summary>
			public Union<string, IntrinsicFunction> MaximumExecutionFrequency { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-configrule.html#cfn-config-configrule-scope
            /// </summary>
			public Union<Scope, IntrinsicFunction> Scope { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-configrule.html#cfn-config-configrule-source
            /// </summary>
			public Union<Source, IntrinsicFunction> Source { get; set; }

        }
    
        public string Type { get; } = "AWS::Config::ConfigRule";
        
        public ConfigRuleProperties Properties { get; } = new ConfigRuleProperties();
    }

	public static class ConfigRuleAttributes
	{
        public static readonly ResourceAttribute<string> Arn = new ResourceAttribute<string>("Arn");
        public static readonly ResourceAttribute<string> Compliance_Type = new ResourceAttribute<string>("Compliance", "Type");
        public static readonly ResourceAttribute<string> ConfigRuleId = new ResourceAttribute<string>("ConfigRuleId");
	}
}
