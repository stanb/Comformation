using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.LicenseManager.Grant
{
    /// <summary>
    /// AWS::LicenseManager::Grant
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-licensemanager-grant.html
    /// </summary>
    public class GrantResource : ResourceBase
    {
        public class GrantProperties
        {
            /// <summary>
            /// GrantName
            /// Grant name.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> GrantName { get; set; }

            /// <summary>
            /// LicenseArn
            /// License ARN.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> LicenseArn { get; set; }

            /// <summary>
            /// HomeRegion
            /// Home Region of the grant.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> HomeRegion { get; set; }

            /// <summary>
            /// AllowedOperations
            /// Allowed operations for the grant.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> AllowedOperations { get; set; }

            /// <summary>
            /// Principals
            /// The grant principals.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> Principals { get; set; }

            /// <summary>
            /// Status
            /// Granted license status.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Status { get; set; }

        }

        public string Type { get; } = "AWS::LicenseManager::Grant";

        public GrantProperties Properties { get; } = new GrantProperties();

    }

    public static class GrantAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> GrantArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("GrantArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Version = new ResourceAttribute<Union<string, IntrinsicFunction>>("Version");
    }
}
