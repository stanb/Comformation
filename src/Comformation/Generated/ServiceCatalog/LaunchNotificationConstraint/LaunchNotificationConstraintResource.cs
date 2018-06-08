using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ServiceCatalog.LaunchNotificationConstraint
{
    /// <summary>
    /// AWS::ServiceCatalog::LaunchNotificationConstraint
    /// Creates a notification constraint for AWS Service Catalog. For more information, see CreateConstraint in the
    /// AWS Service Catalog Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-launchnotificationconstraint.html
    /// </summary>
    public class LaunchNotificationConstraintResource : ResourceBase
    {
        public class LaunchNotificationConstraintProperties
        {
            /// <summary>
            /// Description
            /// The description of the constraint.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// NotificationArns
            /// The notification ARNs.
            /// Required: Yes
            /// Type: List of String values
            /// Update requires: Replacement
            /// </summary>
			public Union<List<string>, IntrinsicFunction> NotificationArns { get; set; }

            /// <summary>
            /// AcceptLanguage
            /// The language code.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> AcceptLanguage { get; set; }

            /// <summary>
            /// PortfolioId
            /// The portfolio identifier.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> PortfolioId { get; set; }

            /// <summary>
            /// ProductId
            /// The product identifier.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ProductId { get; set; }

        }
    
        public string Type { get; } = "AWS::ServiceCatalog::LaunchNotificationConstraint";
        
        public LaunchNotificationConstraintProperties Properties { get; } = new LaunchNotificationConstraintProperties();
    }
}
