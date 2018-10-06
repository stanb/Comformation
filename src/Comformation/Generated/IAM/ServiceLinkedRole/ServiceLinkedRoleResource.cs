using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IAM.ServiceLinkedRole
{
    /// <summary>
    /// AWS::IAM::ServiceLinkedRole
    /// The AWS::IAM::ServiceLinkedRole resource creates a service-linked role in AWS Identity and Access Management
    /// (IAM). A service-linked role is a unique type of IAM role that is linked directly to an AWS service.
    /// Service-linked roles are predefined by the service and include all the permissions that the service requires
    /// to call other AWS services on your behalf. The linked service also defines how you create, modify, and delete
    /// a service-linked role. For more information, see CreateServiceLinkedRole in the IAM API Reference or Using
    /// Service-Linked Roles in the IAM User Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-servicelinkedrole.html
    /// </summary>
    public class ServiceLinkedRoleResource : ResourceBase
    {
        public class ServiceLinkedRoleProperties
        {
            /// <summary>
            /// CustomSuffix
            /// A string that you provide, which is combined with the service-provided prefix to form the complete
            /// role name. If you make multiple requests for the same service, then you must supply a different
            /// CustomSuffix for each request. Otherwise the request fails with a duplicate role name error. For
            /// example, you could add -1 or -debug to the suffix.
            /// Some services do not support the CustomSuffix parameter. If you provide an optional suffix and the
            /// operation fails, try the operation again without the suffix.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> CustomSuffix { get; set; }

            /// <summary>
            /// Description
            /// The description of the role.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// AWSServiceName
            /// The service principal for the AWS service to which this role is attached. You use a string similar
            /// to a URL but without the http:// in front. For example: elasticbeanstalk. amazonaws. com.
            /// Service principals are unique and case sensitive. To find the exact service principal for your
            /// service-linked role, see AWS Services That Work with IAM in the IAM User Guide. Look for the
            /// services that have Yes in the Service-Linked Role column. Choose the Yes link to view the
            /// service-linked role documentation for that service.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> AWSServiceName { get; set; }

        }
    
        public string Type { get; } = "AWS::IAM::ServiceLinkedRole";
        
        public ServiceLinkedRoleProperties Properties { get; } = new ServiceLinkedRoleProperties();

    }
}
