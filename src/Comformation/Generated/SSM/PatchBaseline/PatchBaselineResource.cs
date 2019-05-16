using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSM.PatchBaseline
{
    /// <summary>
    /// AWS::SSM::PatchBaseline
    /// The AWS::SSM::PatchBaseline resource defines the basic information for an AWS Systems Manager patch baseline.
    /// A patch baseline defines which patches are approved for installation on your instances.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-patchbaseline.html
    /// </summary>
    public class PatchBaselineResource : ResourceBase
    {
        public class PatchBaselineProperties
        {
            /// <summary>
            /// OperatingSystem
            /// Defines the operating system the patch baseline applies to. The Default value is WINDOWS.
            /// Required: No
            /// Type: String
            /// Allowed Values: AMAZON_LINUX | AMAZON_LINUX_2 | CENTOS | REDHAT_ENTERPRISE_LINUX | SUSE | UBUNTU |
            /// WINDOWS
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> OperatingSystem { get; set; }

            /// <summary>
            /// Description
            /// A description of the patch baseline.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1024
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// ApprovalRules
            /// A set of rules used to include patches in the baseline.
            /// Required: No
            /// Type: RuleGroup
            /// Update requires: No interruption
            /// </summary>
			public RuleGroup ApprovalRules { get; set; }

            /// <summary>
            /// Sources
            /// Information about the patches to use to update the instances, including target operating systems and
            /// source repositories. Applies to Linux instances only.
            /// Required: No
            /// Type: List of PatchSource
            /// Maximum: 20
            /// Update requires: No interruption
            /// </summary>
			public List<PatchSource> Sources { get; set; }

            /// <summary>
            /// Name
            /// The name of the patch baseline.
            /// Required: Yes
            /// Type: String
            /// Minimum: 3
            /// Maximum: 128
            /// Pattern: ^[a-zA-Z0-9_\-. ]{3,128}$
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// RejectedPatches
            /// A list of explicitly rejected patches for the baseline.
            /// For information about accepted formats for lists of approved patches and rejected patches, see
            /// Package Name Formats for Approved and Rejected Patch Lists in the AWS Systems Manager User Guide.
            /// Required: No
            /// Type: List of String
            /// Maximum: 50
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> RejectedPatches { get; set; }

            /// <summary>
            /// ApprovedPatches
            /// A list of explicitly approved patches for the baseline.
            /// For information about accepted formats for lists of approved patches and rejected patches, see
            /// Package Name Formats for Approved and Rejected Patch Lists in the AWS Systems Manager User Guide.
            /// Required: No
            /// Type: List of String
            /// Maximum: 50
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> ApprovedPatches { get; set; }

            /// <summary>
            /// RejectedPatchesAction
            /// The action for Patch Manager to take on patches included in the RejectedPackages list.
            /// ALLOW_AS_DEPENDENCY: A package in the Rejected patches list is installed only if it is a dependency
            /// of another package. It is considered compliant with the patch baseline, and its status is reported
            /// as InstalledOther. This is the default action if no option is specified. BLOCK: Packages in the
            /// RejectedPatches list, and packages that include them as dependencies, are not installed under any
            /// circumstances. If a package was installed before it was added to the Rejected patches list, it is
            /// considered non-compliant with the patch baseline, and its status is reported as InstalledRejected.
            /// Required: No
            /// Type: String
            /// Allowed Values: ALLOW_AS_DEPENDENCY | BLOCK
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> RejectedPatchesAction { get; set; }

            /// <summary>
            /// PatchGroups
            /// The name of the patch group that should be registered with the patch baseline.
            /// Required: No
            /// Type: List of String
            /// Minimum: 1
            /// Maximum: 256
            /// Pattern: ^([\p{L}\p{Z}\p{N}_. :/=+\-@]*)$
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> PatchGroups { get; set; }

            /// <summary>
            /// ApprovedPatchesComplianceLevel
            /// Defines the compliance level for approved patches. This means that if an approved patch is reported
            /// as missing, this is the severity of the compliance violation. The default value is UNSPECIFIED.
            /// Required: No
            /// Type: String
            /// Allowed Values: CRITICAL | HIGH | INFORMATIONAL | LOW | MEDIUM | UNSPECIFIED
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ApprovedPatchesComplianceLevel { get; set; }

            /// <summary>
            /// ApprovedPatchesEnableNonSecurity
            /// Indicates whether the list of approved patches includes non-security updates that should be applied
            /// to the instances. The default value is &#39;false&#39;. Applies to Linux instances only.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> ApprovedPatchesEnableNonSecurity { get; set; }

            /// <summary>
            /// GlobalFilters
            /// A set of global filters used to include patches in the baseline.
            /// Required: No
            /// Type: PatchFilterGroup
            /// Update requires: No interruption
            /// </summary>
			public PatchFilterGroup GlobalFilters { get; set; }

            /// <summary>
            /// Tags
            /// Optional metadata that you assign to a resource. Tags enable you to categorize a resource in
            /// different ways, such as by purpose, owner, or environment. For example, you might want to tag a
            /// patch baseline to identify the severity level of patches it specifies and the operating system
            /// family it applies to.
            /// Required: No
            /// Type: List of Tag
            /// Maximum: 1000
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::SSM::PatchBaseline";

        public PatchBaselineProperties Properties { get; } = new PatchBaselineProperties();

    }
}
