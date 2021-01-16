using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Config.OrganizationConformancePack
{
    /// <summary>
    /// AWS::Config::OrganizationConformancePack
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-organizationconformancepack.html
    /// </summary>
    public class OrganizationConformancePackResource : ResourceBase
    {
        public class OrganizationConformancePackProperties
        {
            /// <summary>
            /// OrganizationConformancePackName
            /// 		
            /// The name you assign to an organization conformance pack.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Pattern: [a-zA-Z][-a-zA-Z0-9]*
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> OrganizationConformancePackName { get; set; }

            /// <summary>
            /// TemplateS3Uri
            /// Location of file containing the template body. The uri must point to the conformance pack template
            /// (max size: 300 KB).
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> TemplateS3Uri { get; set; }

            /// <summary>
            /// TemplateBody
            /// A string containing full conformance pack template body. Structure containing the template body with
            /// a minimum length of 1 byte and a maximum length of 51,200 bytes.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> TemplateBody { get; set; }

            /// <summary>
            /// DeliveryS3Bucket
            /// 		
            /// Amazon S3 bucket where AWS Config stores conformance pack templates.
            /// 		
            /// Note This field is optional.
            /// 	
            /// Required: No
            /// Type: String
            /// Minimum: 0
            /// Maximum: 63
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> DeliveryS3Bucket { get; set; }

            /// <summary>
            /// DeliveryS3KeyPrefix
            /// 		
            /// Any folder structure you want to add to an Amazon S3 bucket.
            /// 		
            /// Note This field is optional.
            /// 	
            /// Required: No
            /// Type: String
            /// Minimum: 0
            /// Maximum: 1024
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> DeliveryS3KeyPrefix { get; set; }

            /// <summary>
            /// ConformancePackInputParameters
            /// 		
            /// A list of ConformancePackInputParameter objects.
            /// 	
            /// Required: No
            /// Type: List of ConformancePackInputParameter
            /// Maximum: 60
            /// Update requires: No interruption
            /// </summary>
            public List<ConformancePackInputParameter> ConformancePackInputParameters { get; set; }

            /// <summary>
            /// ExcludedAccounts
            /// 		
            /// A comma-separated list of accounts excluded from organization conformance pack.
            /// 	
            /// Required: No
            /// Type: List of String
            /// Maximum: 1000
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> ExcludedAccounts { get; set; }

        }

        public string Type { get; } = "AWS::Config::OrganizationConformancePack";

        public OrganizationConformancePackProperties Properties { get; } = new OrganizationConformancePackProperties();

    }
}
