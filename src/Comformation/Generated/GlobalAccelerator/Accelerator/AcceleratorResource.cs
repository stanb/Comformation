using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.GlobalAccelerator.Accelerator
{
    /// <summary>
    /// AWS::GlobalAccelerator::Accelerator
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-globalaccelerator-accelerator.html
    /// </summary>
    public class AcceleratorResource : ResourceBase
    {
        public class AcceleratorProperties
        {
            /// <summary>
            /// Name
            /// 		
            /// The name of the accelerator. The name must contain only alphanumeric characters or 			hyphens (-),
            /// and must not begin or end with a hyphen.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Maximum: 255
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// IpAddressType
            /// 		
            /// The value for the address type must be IPv4. 			
            /// 		 	
            /// Required: No
            /// Type: String
            /// Allowed values: IPV4
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> IpAddressType { get; set; }

            /// <summary>
            /// IpAddresses
            /// 		
            /// Optionally, if you&#39;ve added your own IP address pool to Global Accelerator (BYOIP), you can choose
            /// IP addresses 			from your own pool to use for the accelerator&#39;s static IP addresses when you create
            /// an accelerator. You can 			specify one or two addresses, separated by a comma. Do not include the
            /// /32 suffix.
            /// 		
            /// Only one IP address from each of your IP address ranges can be used for each accelerator. If you
            /// specify only 			one IP address from your IP address range, Global Accelerator assigns a second
            /// static IP address for the 			accelerator from the AWS IP address pool.
            /// 		
            /// Note that you can&#39;t update IP addresses for an existing accelerator. To change them, you must create
            /// a new 			accelerator with the new addresses.
            /// 		
            /// For more information, see Bring Your Own 			IP Addresses (BYOIP) in the AWS Global Accelerator
            /// Developer Guide.
            /// 	
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> IpAddresses { get; set; }

            /// <summary>
            /// Enabled
            /// 		
            /// Indicates whether the accelerator is enabled. The value is true or false. The default value is true.
            /// 		
            /// If the value is set to true, the accelerator cannot be deleted. If set to false, accelerator can be
            /// deleted.
            /// 	
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> Enabled { get; set; }

            /// <summary>
            /// Tags
            /// 		
            /// Create tags for an accelerator.
            /// 		
            /// For more information, see Tagging 			in AWS Global Accelerator in the AWS Global Accelerator
            /// Developer Guide.
            /// 	
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::GlobalAccelerator::Accelerator";

        public AcceleratorProperties Properties { get; } = new AcceleratorProperties();

    }

    public static class AcceleratorAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> DnsName = new ResourceAttribute<Union<string, IntrinsicFunction>>("DnsName");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> AcceleratorArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("AcceleratorArn");
    }
}
