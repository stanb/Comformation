using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.DirectoryService.SimpleAD
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directoryservice-simplead.html
    /// </summary>
    public class SimpleADResource : ResourceBase
    {
        public class SimpleADProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directoryservice-simplead.html#cfn-directoryservice-simplead-createalias
            /// </summary>
			public Union<bool?, IntrinsicFunction> CreateAlias { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directoryservice-simplead.html#cfn-directoryservice-simplead-description
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directoryservice-simplead.html#cfn-directoryservice-simplead-enablesso
            /// </summary>
			public Union<bool?, IntrinsicFunction> EnableSso { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directoryservice-simplead.html#cfn-directoryservice-simplead-name
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directoryservice-simplead.html#cfn-directoryservice-simplead-password
            /// </summary>
			public Union<string, IntrinsicFunction> Password { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directoryservice-simplead.html#cfn-directoryservice-simplead-shortname
            /// </summary>
			public Union<string, IntrinsicFunction> ShortName { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directoryservice-simplead.html#cfn-directoryservice-simplead-size
            /// </summary>
			public Union<string, IntrinsicFunction> Size { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directoryservice-simplead.html#cfn-directoryservice-simplead-vpcsettings
            /// </summary>
			public Union<VpcSettings, IntrinsicFunction> VpcSettings { get; set; }

        }
    
        public string Type { get; } = "AWS::DirectoryService::SimpleAD";
        
        public SimpleADProperties Properties { get; } = new SimpleADProperties();
    }

	public static class SimpleADAttributes
	{
        public static readonly ResourceAttribute<string> Alias = new ResourceAttribute<string>("Alias");
        public static readonly ResourceAttribute<List<string>> DnsIpAddresses = new ResourceAttribute<List<string>>("DnsIpAddresses");
	}
}
