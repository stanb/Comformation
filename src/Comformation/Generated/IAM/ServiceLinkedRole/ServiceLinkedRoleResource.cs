using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IAM.ServiceLinkedRole
{
    /// <summary>
    /// AWS::IAM::ServiceLinkedRole
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
            /// Minimum: 1
            /// Maximum: 64
            /// Pattern: [\w+=,. @-]+
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> CustomSuffix { get; set; }

            /// <summary>
            /// Description
            /// The description of the role.
            /// Required: No
            /// Type: String
            /// Maximum: 1000
            /// Pattern: [\p{L}\p{M}\p{Z}\p{S}\p{N}\p{P}]*
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// AWSServiceName
            /// The service principal for the AWS service to which this role is attached. You use a string similar
            /// to a URL but without the http:// in front. For example: elasticbeanstalk. amazonaws. com.
            /// Service principals are unique and case-sensitive. To find the exact service principal for your
            /// service-linked role, see AWS services that work with IAM in the IAM User Guide. Look for the
            /// services that have Yes in the Service-Linked Role column. Choose the Yes link to view the
            /// service-linked role documentation for that service.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Pattern: [\w+=,. @-]+
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> AWSServiceName { get; set; }

        }

        public string Type { get; } = "AWS::IAM::ServiceLinkedRole";

        public ServiceLinkedRoleProperties Properties { get; } = new ServiceLinkedRoleProperties();

    }
}
