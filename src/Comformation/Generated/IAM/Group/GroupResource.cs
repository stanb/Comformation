using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IAM.Group
{
    /// <summary>
    /// AWS::IAM::Group
    /// The AWS::IAM::Group resource creates an AWS Identity and Access Management (IAM) group.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-group.html
    /// </summary>
    public class GroupResource : ResourceBase
    {
        public class GroupProperties
        {
            /// <summary>
            /// GroupName
            /// A name for the IAM group. For valid values, see the GroupName parameter for the CreateGroup action
            /// in the IAM API Reference. If you don&#39;t specify a name, AWS CloudFormation generates a unique
            /// physical ID and uses that ID for the group name.
            /// Important If you specify a name, you cannot perform updates that require replacement of this
            /// resource. You can perform updates that require no or some interruption. If you must replace the
            /// resource, specify a new name.
            /// If you specify a name, you must specify the CAPABILITY_NAMED_IAM value to acknowledge your
            /// template&#39;s capabilities. For more information, see Acknowledging IAM Resources in AWS CloudFormation
            /// Templates.
            /// Warning Naming an IAM resource can cause an unrecoverable error if you reuse the same template in
            /// multiple regions. To prevent this, we recommend using Fn::Join and AWS::Region to create a
            /// region-specific name, as in the following example: {&quot;Fn::Join&quot;: [&quot;&quot;, [{&quot;Ref&quot;: &quot;AWS::Region&quot;},
            /// {&quot;Ref&quot;: &quot;MyResourceName&quot;}]]}.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> GroupName { get; set; }

            /// <summary>
            /// ManagedPolicyArns
            /// One or more managed policy ARNs to attach to this group.
            /// Required: No
            /// Type: List of String values
            /// Update requires: No interruption
            /// </summary>
			public Union<List<string>, IntrinsicFunction> ManagedPolicyArns { get; set; }

            /// <summary>
            /// Path
            /// The path to the group. For more information about paths, see IAM Identifiers in the IAM User Guide.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Path { get; set; }

            /// <summary>
            /// Policies
            /// The policies to associate with this group. For information about policies, see Overview of IAM
            /// Policies in the IAM User Guide.
            /// Required: No
            /// Type: List of IAM Policies
            /// Update requires: No interruption
            /// </summary>
			public Union<List<Policy>, IntrinsicFunction> Policies { get; set; }

        }
    
        public string Type { get; } = "AWS::IAM::Group";
        
        public GroupProperties Properties { get; } = new GroupProperties();
    }

	public static class GroupAttributes
	{
        public static readonly ResourceAttribute<string> Arn = new ResourceAttribute<string>("Arn");
	}
}
