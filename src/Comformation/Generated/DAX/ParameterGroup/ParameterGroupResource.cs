using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.DAX.ParameterGroup
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dax-parametergroup.html
    /// </summary>
    public class ParameterGroupResource : ResourceBase
    {
        public class ParameterGroupProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dax-parametergroup.html#cfn-dax-parametergroup-parameternamevalues
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> ParameterNameValues { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dax-parametergroup.html#cfn-dax-parametergroup-description
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dax-parametergroup.html#cfn-dax-parametergroup-parametergroupname
            /// </summary>
			public Union<string, IntrinsicFunction> ParameterGroupName { get; set; }

        }
    
        public string Type { get; } = "AWS::DAX::ParameterGroup";
        
        public ParameterGroupProperties Properties { get; } = new ParameterGroupProperties();
    }
}
