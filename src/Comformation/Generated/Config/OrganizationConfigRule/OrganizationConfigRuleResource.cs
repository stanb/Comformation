using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Config.OrganizationConfigRule
{
    /// <summary>
    /// AWS::Config::OrganizationConfigRule
    /// An organization config rule that has information about config rules that AWS Config creates in member
    /// accounts. Only a master account can create or update an organization config rule.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-organizationconfigrule.html
    /// </summary>
    public class OrganizationConfigRuleResource : ResourceBase
    {
        public class OrganizationConfigRuleProperties
        {
            /// <summary>
            /// OrganizationManagedRuleMetadata
            /// 		
            /// An OrganizationManagedRuleMetadata object.
            /// 	
            /// Required: No
            /// Type: OrganizationManagedRuleMetadata
            /// Update requires: No interruption
            /// </summary>
			public OrganizationManagedRuleMetadata OrganizationManagedRuleMetadata { get; set; }

            /// <summary>
            /// OrganizationConfigRuleName
            /// 		
            /// The name that you assign to organization config rule.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 64
            /// Pattern: . *\S. *
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> OrganizationConfigRuleName { get; set; }

            /// <summary>
            /// OrganizationCustomRuleMetadata
            /// 		
            /// An OrganizationCustomRuleMetadata object.
            /// 	
            /// Required: No
            /// Type: OrganizationCustomRuleMetadata
            /// Update requires: No interruption
            /// </summary>
			public OrganizationCustomRuleMetadata OrganizationCustomRuleMetadata { get; set; }

            /// <summary>
            /// ExcludedAccounts
            /// 		
            /// A comma-separated list of accounts excluded from organization config rule.
            /// 	
            /// Required: No
            /// Type: List of String
            /// Maximum: 1000
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> ExcludedAccounts { get; set; }

        }

        public string Type { get; } = "AWS::Config::OrganizationConfigRule";

        public OrganizationConfigRuleProperties Properties { get; } = new OrganizationConfigRuleProperties();

    }
}
