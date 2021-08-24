using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFormation.StackSet
{
    /// <summary>
    /// AWS::CloudFormation::StackSet
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-stackset.html
    /// </summary>
    public class StackSetResource : ResourceBase
    {
        public class StackSetProperties
        {
            /// <summary>
            /// StackSetName
            /// The name to associate with the stack set. The name must be unique in the Region where you create
            /// your stack set.
            /// Maximum: 128
            /// Pattern: ^[a-zA-Z][a-zA-Z0-9-]{0,127}$
            /// Note The StackSetName property is required.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> StackSetName { get; set; }

            /// <summary>
            /// AdministrationRoleARN
            /// The Amazon Resource Number (ARN) of the IAM role to use to create this stack set. Specify an IAM
            /// role only if you are using customized administrator roles to control which users or groups can
            /// manage specific stack sets within the same administrator account.
            /// Use customized administrator roles to control which users or groups can manage specific stack sets
            /// within the same administrator account. For more information, see Prerequisites: Granting Permissions
            /// for Stack Set Operations in the AWS CloudFormation User Guide.
            /// Minimum: 20
            /// Maximum: 2048
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> AdministrationRoleARN { get; set; }

            /// <summary>
            /// AutoDeployment
            /// [Service-managed permissions] Describes whether StackSets automatically deploys to AWS Organizations
            /// accounts that are added to a target organization or organizational unit (OU).
            /// Required: No
            /// Type: AutoDeployment
            /// Update requires: No interruption
            /// </summary>
            public AutoDeployment AutoDeployment { get; set; }

            /// <summary>
            /// Capabilities
            /// The capabilities that are allowed in the stack set. Some stack set templates might include resources
            /// that can affect permissions in your AWS account—for example, by creating new AWS Identity and Access
            /// Management (IAM) users. For more information, see Acknowledging IAM Resources in AWS CloudFormation
            /// Templates.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> Capabilities { get; set; }

            /// <summary>
            /// Description
            /// A description of the stack set.
            /// Minimum: 1
            /// Maximum: 1024
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// ExecutionRoleName
            /// The name of the IAM execution role to use to create the stack set. If you do not specify an
            /// execution role, AWS CloudFormation uses the AWSCloudFormationStackSetExecutionRole role for the
            /// stack set operation.
            /// Minimum: 1
            /// Maximum: 64
            /// Pattern: [a-zA-Z_0-9+=,. @-]+
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ExecutionRoleName { get; set; }

            /// <summary>
            /// OperationPreferences
            /// The user-specified preferences for how AWS CloudFormation performs a stack set operation.
            /// Required: No
            /// Type: OperationPreferences
            /// Update requires: No interruption
            /// </summary>
            public OperationPreferences OperationPreferences { get; set; }

            /// <summary>
            /// StackInstancesGroup
            /// A group of stack instances with parameters in some specific accounts and Regions.
            /// Required: No
            /// Type: List of StackInstances
            /// Update requires: No interruption
            /// </summary>
            public List<StackInstances> StackInstancesGroup { get; set; }

            /// <summary>
            /// Parameters
            /// The input parameters for the stack set template.
            /// Required: No
            /// Type: List of Parameter
            /// Update requires: No interruption
            /// </summary>
            public List<Parameter> Parameters { get; set; }

            /// <summary>
            /// PermissionModel
            /// Describes how the IAM roles required for stack set operations are created.
            /// With SELF_MANAGED permissions, you must create the administrator and execution roles required to
            /// deploy to target accounts. For more information, see Grant Self-Managed Stack Set Permissions. With
            /// SERVICE_MANAGED permissions, StackSets automatically creates the IAM roles required to deploy to
            /// accounts managed by AWS Organizations. For more information, see Grant Service-Managed Stack Set
            /// Permissions.
            /// Allowed Values: SERVICE_MANAGED | SELF_MANAGED
            /// Note The PermissionModel property is required.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> PermissionModel { get; set; }

            /// <summary>
            /// Tags
            /// The key-value pairs to associate with this stack set and the stacks created from it. AWS
            /// CloudFormation also propagates these tags to supported resources that are created in the stacks. A
            /// maximum number of 50 tags can be specified.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// TemplateBody
            /// The structure that contains the template body, with a minimum length of 1 byte and a maximum length
            /// of 51,200 bytes.
            /// You must include either TemplateURL or TemplateBody in a StackSet, but you cannot use both.
            /// Minimum: 1
            /// Maximum: 51200
            /// Required: Conditional
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> TemplateBody { get; set; }

            /// <summary>
            /// TemplateURL
            /// Location of file containing the template body. The URL must point to a template (max size: 460,800
            /// bytes) that is located in an Amazon S3 bucket.
            /// You must include either TemplateURL or TemplateBody in a StackSet, but you cannot use both.
            /// Minimum: 1
            /// Maximum: 1024
            /// Required: Conditional
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> TemplateURL { get; set; }

            /// <summary>
            /// CallAs
            /// [Service-managed permissions] Specifies whether you are acting as an account administrator in the
            /// organization&#39;s management account or as a delegated administrator in a member account.
            /// By default, SELF is specified. Use SELF for stack sets with self-managed permissions.
            /// To create a stack set with service-managed permissions while signed in to the management account,
            /// specify SELF. To create a stack set with service-managed permissions while signed in to a delegated
            /// administrator account, specify DELEGATED_ADMIN. Your AWS account must be registered as a delegated
            /// admin in the management account. For more information, see Register a delegated administrator in the
            /// AWS CloudFormation User Guide.
            /// Stack sets with service-managed permissions are created in the management account, including stack
            /// sets that are created by delegated administrators.
            /// Valid Values: SELF | DELEGATED_ADMIN
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> CallAs { get; set; }

        }

        public string Type { get; } = "AWS::CloudFormation::StackSet";

        public StackSetProperties Properties { get; } = new StackSetProperties();

    }

    public static class StackSetAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> StackSetId = new ResourceAttribute<Union<string, IntrinsicFunction>>("StackSetId");
    }
}
