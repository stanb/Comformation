using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.LicenseManager.License
{
    /// <summary>
    /// AWS::LicenseManager::License
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-licensemanager-license.html
    /// </summary>
    public class LicenseResource : ResourceBase
    {
        public class LicenseProperties
        {
            /// <summary>
            /// ProductSKU
            /// Product SKU.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ProductSKU { get; set; }

            /// <summary>
            /// Issuer
            /// License issuer.
            /// Required: Yes
            /// Type: IssuerData
            /// Update requires: No interruption
            /// </summary>
            public IssuerData Issuer { get; set; }

            /// <summary>
            /// LicenseName
            /// License name.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> LicenseName { get; set; }

            /// <summary>
            /// ProductName
            /// Product name.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ProductName { get; set; }

            /// <summary>
            /// HomeRegion
            /// Home Region of the license.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> HomeRegion { get; set; }

            /// <summary>
            /// Validity
            /// Date and time range during which the license is valid, in ISO8601-UTC format.
            /// Required: Yes
            /// Type: ValidityDateFormat
            /// Update requires: No interruption
            /// </summary>
            public ValidityDateFormat Validity { get; set; }

            /// <summary>
            /// Entitlements
            /// License entitlements.
            /// Required: Yes
            /// Type: List of Entitlement
            /// Update requires: No interruption
            /// </summary>
            public List<Entitlement> Entitlements { get; set; }

            /// <summary>
            /// Beneficiary
            /// License beneficiary.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Beneficiary { get; set; }

            /// <summary>
            /// ConsumptionConfiguration
            /// Configuration for consumption of the license.
            /// Required: Yes
            /// Type: ConsumptionConfiguration
            /// Update requires: No interruption
            /// </summary>
            public ConsumptionConfiguration ConsumptionConfiguration { get; set; }

            /// <summary>
            /// LicenseMetadata
            /// License metadata.
            /// Required: No
            /// Type: List of Metadata
            /// Update requires: No interruption
            /// </summary>
            public List<Metadata> LicenseMetadata { get; set; }

            /// <summary>
            /// Status
            /// License status.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Status { get; set; }

        }

        public string Type { get; } = "AWS::LicenseManager::License";

        public LicenseProperties Properties { get; } = new LicenseProperties();

    }

    public static class LicenseAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> LicenseArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("LicenseArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Version = new ResourceAttribute<Union<string, IntrinsicFunction>>("Version");
    }
}
