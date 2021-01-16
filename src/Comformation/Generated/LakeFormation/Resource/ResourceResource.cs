using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.LakeFormation.Resource
{
    /// <summary>
    /// AWS::LakeFormation::Resource
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lakeformation-resource.html
    /// </summary>
    public class ResourceResource : ResourceBase
    {
        public class ResourceProperties
        {
            /// <summary>
            /// ResourceArn
            /// The Amazon Resource Name (ARN) of the resource.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ResourceArn { get; set; }

            /// <summary>
            /// UseServiceLinkedRole
            /// 	
            /// Designates a trusted caller, an IAM principal, by registering this caller with the Data Catalog.
            /// Required: Yes
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> UseServiceLinkedRole { get; set; }

            /// <summary>
            /// RoleArn
            /// The IAM role that registered a resource.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> RoleArn { get; set; }

        }

        public string Type { get; } = "AWS::LakeFormation::Resource";

        public ResourceProperties Properties { get; } = new ResourceProperties();

    }
}
