using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ACMPCA.CertificateAuthority
{
    /// <summary>
    /// AWS::ACMPCA::CertificateAuthority CrlConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-crlconfiguration.html
    /// </summary>
    public class CrlConfiguration
    {

        /// <summary>
        /// Enabled
        /// 		
        /// Boolean value that specifies whether certificate revocation lists (CRLs) are enabled. 			You can use
        /// this value to enable certificate revocation for a new CA when you call the
        /// 				CreateCertificateAuthority action or for an existing CA when you call the
        /// 				UpdateCertificateAuthority action.
        /// 	
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Enabled")]
        public Union<bool, IntrinsicFunction> Enabled { get; set; }

        /// <summary>
        /// ExpirationInDays
        /// 		
        /// Validity period of the CRL in days.
        /// 	
        /// Required: No
        /// Type: Integer
        /// Minimum: 1
        /// Maximum: 5000
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ExpirationInDays")]
        public Union<int, IntrinsicFunction> ExpirationInDays { get; set; }

        /// <summary>
        /// CustomCname
        /// Name inserted into the certificate CRL Distribution Points extension that enables the use of an
        /// alias for the CRL distribution point. Use this value if you don&#39;t want the name of your S3 bucket to
        /// be public.
        /// Required: No
        /// Type: String
        /// Minimum: 0
        /// Maximum: 253
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CustomCname")]
        public Union<string, IntrinsicFunction> CustomCname { get; set; }

        /// <summary>
        /// S3BucketName
        /// 		
        /// Name of the S3 bucket that contains the CRL. If you do not provide a value for the 				CustomCname
        /// argument, the name of your S3 bucket 			is placed into the CRL Distribution Points extension of
        /// 			the issued certificate. You can change the name of your bucket by calling the
        /// UpdateCertificateAuthority action. You must specify a bucket policy that 			allows ACM Private CA to
        /// write the CRL to your bucket.
        /// 	
        /// Required: No
        /// Type: String
        /// Minimum: 3
        /// Maximum: 255
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3BucketName")]
        public Union<string, IntrinsicFunction> S3BucketName { get; set; }

    }
}
