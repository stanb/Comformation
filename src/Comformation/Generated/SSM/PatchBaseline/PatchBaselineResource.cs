using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSM.PatchBaseline
{
    /// <summary>
    /// AWS::SSM::PatchBaseline
    /// The AWS::SSM::PatchBaseline resource defines the basic information for an AWS Systems Manager patch baseline.
    /// A patch baseline defines which patches are approved for installation on your instances. For more information,
    /// see CreatePatchBaseline in the AWS Systems Manager API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-patchbaseline.html
    /// </summary>
    public class PatchBaselineResource : ResourceBase
    {
        public class PatchBaselineProperties
        {
            /// <summary>
            /// OperatingSystem
            /// Defines the operating system that the patch baseline applies to. Supported operating systems include
            /// WINDOWS, AMAZON_LINUX, AMAZON_LINUX_2, UBUNTU, REDHAT_ENTERPRISE_LINUX, SUSE, and CENTOS. The
            /// default value is WINDOWS.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> OperatingSystem { get; set; }

            /// <summary>
            /// ApprovedPatches
            /// A list of explicitly approved patches for the baseline.
            /// Required: No
            /// Type: List of String values
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> ApprovedPatches { get; set; }

            /// <summary>
            /// RejectedPatchesAction
            /// </summary>
			public Union<string, IntrinsicFunction> RejectedPatchesAction { get; set; }

            /// <summary>
            /// PatchGroups
            /// The names of the patch groups to register with the patch baseline.
            /// Required: No
            /// Type: List of String values
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> PatchGroups { get; set; }

            /// <summary>
            /// Description
            /// A description of the patch baseline.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// ApprovedPatchesComplianceLevel
            /// The compliance level for approved patches. This means that if an approved patch is reported as
            /// missing, this is the severity of the compliance violation. Valid compliance severity levels include
            /// the following: CRITICAL, HIGH, MEDIUM, LOW, INFORMATIONAL, and UNSPECIFIED. The default value is
            /// UNSPECIFIED.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ApprovedPatchesComplianceLevel { get; set; }

            /// <summary>
            /// ApprovedPatchesEnableNonSecurity
            /// </summary>
			public Union<bool, IntrinsicFunction> ApprovedPatchesEnableNonSecurity { get; set; }

            /// <summary>
            /// ApprovalRules
            /// A set of rules that are used to include patches in the baseline.
            /// Required: No
            /// Type: RuleGroup
            /// Update requires: No interruption
            /// </summary>
			public RuleGroup ApprovalRules { get; set; }

            /// <summary>
            /// GlobalFilters
            /// A set of global filters that are used to exclude patches from the baseline.
            /// Required: No
            /// Type: PatchFilterGroup
            /// Update requires: No interruption
            /// </summary>
			public PatchFilterGroup GlobalFilters { get; set; }

            /// <summary>
            /// Sources
            /// </summary>
			public List<PatchSource> Sources { get; set; }

            /// <summary>
            /// Name
            /// The name of the patch baseline.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// RejectedPatches
            /// A list of explicitly rejected patches for the baseline.
            /// Required: No
            /// Type: List of String values
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> RejectedPatches { get; set; }

        }

        public string Type { get; } = "AWS::SSM::PatchBaseline";

        public PatchBaselineProperties Properties { get; } = new PatchBaselineProperties();

    }
}
