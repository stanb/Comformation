using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppStream.StackFleetAssociation
{
    /// <summary>
    /// AWS::AppStream::StackFleetAssociation
    /// The AWS::AppStream::StackFleetAssociation resource associates the specified fleet with the specified stack for
    /// Amazon AppStream 2. 0.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-stackfleetassociation.html
    /// </summary>
    public class StackFleetAssociationResource : ResourceBase
    {
        public class StackFleetAssociationProperties
        {
            /// <summary>
            /// FleetName
            /// The name of the fleet.
            /// To associate a fleet with a stack, you must specify a dependency on the fleet resource. For more
            /// information, see DependsOn Attribute.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> FleetName { get; set; }

            /// <summary>
            /// StackName
            /// The name of the stack.
            /// To associate a fleet with a stack, you must specify a dependency on the stack resource. For more
            /// information, see DependsOn Attribute.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> StackName { get; set; }

        }

        public string Type { get; } = "AWS::AppStream::StackFleetAssociation";

        public StackFleetAssociationProperties Properties { get; } = new StackFleetAssociationProperties();

    }
}
