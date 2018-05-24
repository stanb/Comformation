using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.DirectoryService.MicrosoftAD
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directoryservice-microsoftad.html
    /// </summary>
    public class MicrosoftADResource : ResourceBase
    {
        public class MicrosoftADProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directoryservice-microsoftad.html#cfn-directoryservice-microsoftad-createalias
            /// </summary>
			public Union<bool?, IntrinsicFunction> CreateAlias { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directoryservice-microsoftad.html#cfn-directoryservice-microsoftad-enablesso
            /// </summary>
			public Union<bool?, IntrinsicFunction> EnableSso { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directoryservice-microsoftad.html#cfn-directoryservice-microsoftad-name
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directoryservice-microsoftad.html#cfn-directoryservice-microsoftad-password
            /// </summary>
			public Union<string, IntrinsicFunction> Password { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directoryservice-microsoftad.html#cfn-directoryservice-microsoftad-shortname
            /// </summary>
			public Union<string, IntrinsicFunction> ShortName { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directoryservice-microsoftad.html#cfn-directoryservice-microsoftad-vpcsettings
            /// </summary>
			public Union<VpcSettings, IntrinsicFunction> VpcSettings { get; set; }

        }
    
        public string Type { get; } = "AWS::DirectoryService::MicrosoftAD";
        
        public MicrosoftADProperties Properties { get; } = new MicrosoftADProperties();
    }

	public static class MicrosoftADAttributes
	{
        public static readonly ResourceAttribute<string> Alias = new ResourceAttribute<string>("Alias");
        public static readonly ResourceAttribute<List<string>> DnsIpAddresses = new ResourceAttribute<List<string>>("DnsIpAddresses");
	}
}
