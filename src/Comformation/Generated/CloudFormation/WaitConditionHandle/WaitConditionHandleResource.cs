using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFormation.WaitConditionHandle
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waitconditionhandle.html
    /// </summary>
    public class WaitConditionHandleResource : ResourceBase
    {
        public class WaitConditionHandleProperties
        {
        }
    
        public string Type { get; } = "AWS::CloudFormation::WaitConditionHandle";
        
        public WaitConditionHandleProperties Properties { get; } = new WaitConditionHandleProperties();
    }
}
