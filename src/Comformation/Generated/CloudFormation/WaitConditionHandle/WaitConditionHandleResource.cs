using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFormation.WaitConditionHandle
{
    /// <summary>
    /// AWS::CloudFormation::WaitConditionHandle
    /// Important For Amazon EC2 and Auto Scaling resources, we recommend that you use a CreationPolicy attribute
    /// instead of wait conditions. Add a CreationPolicy attribute to those resources, and use the cfn-signal helper
    /// script to signal when an instance creation process has completed successfully. For more information, see
    /// Deploying Applications on Amazon EC2 with AWS CloudFormation.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waitconditionhandle.html
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
