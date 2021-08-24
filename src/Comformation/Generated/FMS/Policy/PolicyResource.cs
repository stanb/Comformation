using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.FMS.Policy
{
    /// <summary>
    /// AWS::FMS::Policy
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fms-policy.html
    /// </summary>
    public class PolicyResource : ResourceBase
    {
        public class PolicyProperties
        {
            /// <summary>
            /// ExcludeMap
            /// Specifies the AWS account IDs and AWS Organizations organizational units (OUs) to exclude from the
            /// policy. Specifying an OU is the equivalent of specifying all accounts in the OU and in any of its
            /// child OUs, including any child OUs and accounts that are added at a later time.
            /// You can specify inclusions or exclusions, but not both. If you specify an IncludeMap, AWS Firewall
            /// Manager applies the policy to all accounts specified by the IncludeMap, and does not evaluate any
            /// ExcludeMap specifications. If you do not specify an IncludeMap, then Firewall Manager applies the
            /// policy to all accounts except for those specified by the ExcludeMap.
            /// You can specify account IDs, OUs, or a combination:
            /// Specify account IDs by setting the key to ACCOUNT. For example, the following is a valid map:
            /// {“ACCOUNT” : [“accountID1”, “accountID2”]}. Specify OUs by setting the key to ORGUNIT. For example,
            /// the following is a valid map: {“ORGUNIT” : [“ouid111”, “ouid112”]}. Specify accounts and OUs
            /// together in a single map, separated with a comma. For example, the following is a valid map:
            /// {“ACCOUNT” : [“accountID1”, “accountID2”], “ORGUNIT” : [“ouid111”, “ouid112”]}.
            /// Required: No
            /// Type: IEMap
            /// Update requires: No interruption
            /// </summary>
            public IEMap ExcludeMap { get; set; }

            /// <summary>
            /// ExcludeResourceTags
            /// Used only when tags are specified in the ResourceTags property. If this property is True, resources
            /// with the specified tags are not in scope of the policy. If it&#39;s False, only resources with the
            /// specified tags are in scope of the policy.
            /// Required: Yes
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> ExcludeResourceTags { get; set; }

            /// <summary>
            /// IncludeMap
            /// Specifies the AWS account IDs and AWS Organizations organizational units (OUs) to include in the
            /// policy. Specifying an OU is the equivalent of specifying all accounts in the OU and in any of its
            /// child OUs, including any child OUs and accounts that are added at a later time.
            /// You can specify inclusions or exclusions, but not both. If you specify an IncludeMap, AWS Firewall
            /// Manager applies the policy to all accounts specified by the IncludeMap, and does not evaluate any
            /// ExcludeMap specifications. If you do not specify an IncludeMap, then Firewall Manager applies the
            /// policy to all accounts except for those specified by the ExcludeMap.
            /// You can specify account IDs, OUs, or a combination:
            /// Specify account IDs by setting the key to ACCOUNT. For example, the following is a valid map:
            /// {“ACCOUNT” : [“accountID1”, “accountID2”]}. Specify OUs by setting the key to ORGUNIT. For example,
            /// the following is a valid map: {“ORGUNIT” : [“ouid111”, “ouid112”]}. Specify accounts and OUs
            /// together in a single map, separated with a comma. For example, the following is a valid map:
            /// {“ACCOUNT” : [“accountID1”, “accountID2”], “ORGUNIT” : [“ouid111”, “ouid112”]}.
            /// Required: No
            /// Type: IEMap
            /// Update requires: No interruption
            /// </summary>
            public IEMap IncludeMap { get; set; }

            /// <summary>
            /// PolicyName
            /// The name of the AWS Firewall Manager policy.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Pattern: ^([\p{L}\p{Z}\p{N}_. :/=+\-@]*)$
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> PolicyName { get; set; }

            /// <summary>
            /// RemediationEnabled
            /// Indicates if the policy should be automatically applied to new resources.
            /// Required: Yes
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> RemediationEnabled { get; set; }

            /// <summary>
            /// ResourceTags
            /// An array of ResourceTag objects, used to explicitly include resources in the policy scope or
            /// explicitly exclude them. If this isn&#39;t set, then tags aren&#39;t used to modify policy scope. See also
            /// ExcludeResourceTags.
            /// Required: No
            /// Type: List of ResourceTag
            /// Maximum: 8
            /// Update requires: No interruption
            /// </summary>
            public List<ResourceTag> ResourceTags { get; set; }

            /// <summary>
            /// ResourceType
            /// The type of resource protected by or in scope of the policy. This is in the format shown in the AWS
            /// Resource Types Reference. To apply this policy to multiple resource types, specify a resource type
            /// of ResourceTypeList and then specify the resource types in a ResourceTypeList.
            /// For AWS WAF and Shield Advanced, example resource types include
            /// AWS::ElasticLoadBalancingV2::LoadBalancer and AWS::CloudFront::Distribution. For a security group
            /// common policy, valid values are AWS::EC2::NetworkInterface and AWS::EC2::Instance. For a security
            /// group content audit policy, valid values are AWS::EC2::SecurityGroup, AWS::EC2::NetworkInterface,
            /// and AWS::EC2::Instance. For a security group usage audit policy, the value is
            /// AWS::EC2::SecurityGroup. For an AWS Network Firewall policy or DNS Firewall policy, the value is
            /// AWS::EC2::VPC.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Pattern: ^([\p{L}\p{Z}\p{N}_. :/=+\-@]*)$
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ResourceType { get; set; }

            /// <summary>
            /// ResourceTypeList
            /// An array of ResourceType objects. Use this only to specify multiple resource types. To specify a
            /// single resource type, use ResourceType.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> ResourceTypeList { get; set; }

            /// <summary>
            /// SecurityServicePolicyData
            /// Details about the security service that is being used to protect the resources.
            /// This contains the following settings:
            /// Type - Indicates the service type that the policy uses to protect the resource. For security group
            /// policies, Firewall Manager supports one security group for each common policy and for each content
            /// audit policy. This is an adjustable limit that you can increase by contacting AWS Support. Valid
            /// values: WAFV2 | WAF |SHIELD_ADVANCED | SECURITY_GROUPS_COMMON | SECURITY_GROUPS_CONTENT_AUDIT |
            /// SECURITY_GROUPS_USAGE_AUDIT | NETWORK_FIREWALL | DNS_FIREWALL. ManagedServiceData - Details about
            /// the service that are specific to the service type, in JSON format. For SHIELD_ADVANCED, this is an
            /// empty string. Example: WAFV2 &quot;ManagedServiceData&quot;:
            /// &quot;{\&quot;type\&quot;:\&quot;WAFV2\&quot;,\&quot;preProcessRuleGroups\&quot;:[{\&quot;ruleGroupArn\&quot;:null,\&quot;overrideAction\&quot;:{\&quot;type\&quot;:\&quot;NONE\&quot;},\&quot;managedRuleGroupIdentifier\&quot;:{\&quot;version\&quot;:null,\&quot;vendorName\&quot;:\&quot;AWS\&quot;,\&quot;managedRuleGroupName\&quot;:\&quot;AWSManagedRulesAmazonIpReputationList\&quot;},\&quot;ruleGroupType\&quot;:\&quot;ManagedRuleGroup\&quot;,\&quot;excludeRules\&quot;:[]}],\&quot;postProcessRuleGroups\&quot;:[],\&quot;defaultAction\&quot;:{\&quot;type\&quot;:\&quot;ALLOW\&quot;},\&quot;overrideCustomerWebACLAssociation\&quot;:false,\&quot;loggingConfiguration\&quot;:{\&quot;logDestinationConfigs\&quot;:[\&quot;arn:aws:firehose:us-west-2:12345678912:deliverystream/aws-waf-logs-fms-admin-destination\&quot;],\&quot;redactedFields\&quot;:[{\&quot;redactedFieldType\&quot;:\&quot;SingleHeader\&quot;,\&quot;redactedFieldValue\&quot;:\&quot;Cookies\&quot;},{\&quot;redactedFieldType\&quot;:\&quot;Method\&quot;}]}}&quot;
            /// In the loggingConfiguration, you can specify one logDestinationConfigs, you can optionally provide
            /// up to 20 redactedFields, and the RedactedFieldType must be one of URI, QUERY_STRING, HEADER, or
            /// METHOD. Example: WAF Classic &quot;ManagedServiceData&quot;: &quot;{\&quot;type\&quot;: \&quot;WAF\&quot;, \&quot;ruleGroups\&quot;:
            /// [{\&quot;id\&quot;:\&quot;12345678-1bcd-9012-efga-0987654321ab\&quot;, \&quot;overrideAction\&quot; : {\&quot;type\&quot;:
            /// \&quot;COUNT\&quot;}}],\&quot;defaultAction\&quot;: {\&quot;type\&quot;: \&quot;BLOCK\&quot;}} AWS WAF Classic doesn&#39;t support rule groups
            /// in CloudFront. To create a WAF Classic policy through CloudFormation, create your rule groups
            /// outside of CloudFront, then provide the rule group IDs in the WAF managed service data
            /// specification. Example: SECURITY_GROUPS_COMMON
            /// &quot;SecurityServicePolicyData&quot;:{&quot;Type&quot;:&quot;SECURITY_GROUPS_COMMON&quot;,&quot;ManagedServiceData&quot;:&quot;{\&quot;type\&quot;:\&quot;SECURITY_GROUPS_COMMON\&quot;,\&quot;revertManualSecurityGroupChanges\&quot;:false,\&quot;exclusiveResourceSecurityGroupManagement\&quot;:false,\&quot;securityGroups\&quot;:[{\&quot;id\&quot;:\&quot;
            /// sg-000e55995d61a06bd\&quot;}]}&quot;},&quot;RemediationEnabled&quot;:false,&quot;ResourceType&quot;:&quot;AWS::EC2::NetworkInterface&quot;}
            /// Example: SECURITY_GROUPS_CONTENT_AUDIT
            /// &quot;SecurityServicePolicyData&quot;:{&quot;Type&quot;:&quot;SECURITY_GROUPS_CONTENT_AUDIT&quot;,&quot;ManagedServiceData&quot;:&quot;{\&quot;type\&quot;:\&quot;SECURITY_GROUPS_CONTENT_AUDIT\&quot;,\&quot;securityGroups\&quot;:[{\&quot;id\&quot;:\&quot;
            /// sg-000e55995d61a06bd
            /// \&quot;}],\&quot;securityGroupAction\&quot;:{\&quot;type\&quot;:\&quot;ALLOW\&quot;}}&quot;},&quot;RemediationEnabled&quot;:false,&quot;ResourceType&quot;:&quot;AWS::EC2::NetworkInterface&quot;}
            /// The security group action for content audit can be ALLOW or DENY. For ALLOW, all in-scope security
            /// group rules must be within the allowed range of the policy&#39;s security group rules. For DENY, all
            /// in-scope security group rules must not contain a value or a range that matches a rule value or range
            /// in the policy security group. Example: SECURITY_GROUPS_USAGE_AUDIT
            /// &quot;SecurityServicePolicyData&quot;:{&quot;Type&quot;:&quot;SECURITY_GROUPS_USAGE_AUDIT&quot;,&quot;ManagedServiceData&quot;:&quot;{\&quot;type\&quot;:\&quot;SECURITY_GROUPS_USAGE_AUDIT\&quot;,\&quot;deleteUnusedSecurityGroups\&quot;:true,\&quot;coalesceRedundantSecurityGroups\&quot;:true}&quot;},&quot;RemediationEnabled&quot;:false,&quot;Resou
            /// rceType&quot;:&quot;AWS::EC2::SecurityGroup&quot;} Example: NETWORK_FIREWALL
            /// &quot;ManagedServiceData&quot;:&quot;{\&quot;type\&quot;:\&quot;NETWORK_FIREWALL\&quot;,\&quot;networkFirewallStatelessRuleGroupReferences\&quot;:[{\&quot;resourceARN\&quot;:\&quot;arn:aws:network-firewall:us-east-1:000000000000:stateless-rulegroup\/example\&quot;,\&quot;priority\&quot;:1}],\&quot;networkFirewallStatelessDefaultActions\&quot;:[\&quot;aws:drop\&quot;,\&quot;example\&quot;],\&quot;networkFirewallStatelessFragmentDefaultActions\&quot;:[\&quot;aws:drop\&quot;,\&quot;example\&quot;],\&quot;networkFirewallStatelessCustomActions\&quot;:[{\&quot;actionName\&quot;:\&quot;example\&quot;,\&quot;actionDefinition\&quot;:{\&quot;publishMetricAction\&quot;:{\&quot;dimensions\&quot;:[{\&quot;value\&quot;:\&quot;example\&quot;}]}}}],\&quot;networkFirewallStatefulRuleGroupReferences\&quot;:[{\&quot;resourceARN\&quot;:\&quot;arn:aws:network-firewall:us-east-1:000000000000:stateful-rulegroup\/example\&quot;}],\&quot;networkFirewallOrchestrationConfig\&quot;:{\&quot;singleFirewallEndpointPerVPC\&quot;:false,\&quot;allowedIPV4CidrList\&quot;:[]}}&quot;
            /// Example: DNS_FIREWALL &quot;ManagedServiceData&quot;: &quot;{ \&quot;type\&quot;: \&quot;DNS_FIREWALL\&quot;, \&quot;preProcessRuleGroups\&quot;:
            /// [{\&quot;ruleGroupId\&quot;: \&quot;rslvr-frg-123456\&quot;, \&quot;priority\&quot;: 11}], \&quot;postProcessRuleGroups\&quot;:
            /// [{\&quot;ruleGroupId\&quot;: \&quot;rslvr-frg-123456\&quot;, \&quot;priority\&quot;: 9902}]}&quot;
            /// Required: Yes
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> SecurityServicePolicyData { get; set; }

            /// <summary>
            /// DeleteAllPolicyResources
            /// Used when deleting a policy. If true, Firewall Manager performs cleanup according to the policy
            /// type.
            /// For AWS WAF and Shield Advanced policies, Firewall Manager does the following:
            /// Deletes rule groups created by Firewall Manager Removes web ACLs from in-scope resources Deletes web
            /// ACLs that contain no rules or rule groups
            /// For security group policies, Firewall Manager does the following for each security group in the
            /// policy:
            /// Disassociates the security group from in-scope resources Deletes the security group if it was
            /// created through Firewall Manager and if it&#39;s no longer associated with any resources through another
            /// policy
            /// After the cleanup, in-scope resources are no longer protected by web ACLs in this policy. Protection
            /// of out-of-scope resources remains unchanged. Scope is determined by tags that you create and
            /// accounts that you associate with the policy. When creating the policy, if you specify that only
            /// resources in specific accounts or with specific tags are in scope of the policy, those accounts and
            /// resources are handled by the policy. All others are out of scope. If you don&#39;t specify tags or
            /// accounts, all resources are in scope.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> DeleteAllPolicyResources { get; set; }

            /// <summary>
            /// Tags
            /// A collection of key:value pairs associated with an AWS resource. The key:value pair can be anything
            /// you define. Typically, the tag key represents a category (such as &quot;environment&quot;) and the tag value
            /// represents a specific value within that category (such as &quot;test,&quot; &quot;development,&quot; or &quot;production&quot;).
            /// You can add up to 50 tags to each AWS resource.
            /// Required: No
            /// Type: List of PolicyTag
            /// Update requires: No interruption
            /// </summary>
            public List<PolicyTag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::FMS::Policy";

        public PolicyProperties Properties { get; } = new PolicyProperties();

    }

    public static class PolicyAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
