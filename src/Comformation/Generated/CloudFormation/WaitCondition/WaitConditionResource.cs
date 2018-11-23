using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFormation.WaitCondition
{
    /// <summary>
    /// AWS::CloudFormation::WaitCondition
    /// Important For Amazon EC2 and Auto Scaling resources, we recommend that you use a CreationPolicy attribute
    /// instead of wait conditions. Add a CreationPolicy attribute to those resources, and use the cfn-signal helper
    /// script to signal when an instance creation process has completed successfully.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waitcondition.html
    /// </summary>
    public class WaitConditionResource : ResourceBase
    {
        public class WaitConditionProperties
        {
            /// <summary>
            /// Count
            /// The number of success signals that AWS CloudFormation must receive before it continues the stack
            /// creation process. When the wait condition receives the requisite number of success signals, AWS
            /// CloudFormation resumes the creation of the stack. If the wait condition does not receive the
            /// specified number of success signals before the Timeout period expires, AWS CloudFormation assumes
            /// that the wait condition has failed and rolls the stack back.
            /// Required: No
            /// Type: Integer
            /// Update requires: Updates are not supported.
            /// </summary>
			public Union<int, IntrinsicFunction> Count { get; set; }

            /// <summary>
            /// Handle
            /// A reference to the wait condition handle used to signal this wait condition. Use the Ref intrinsic
            /// function to specify an AWS::CloudFormation::WaitConditionHandle resource.
            /// Anytime you add a WaitCondition resource during a stack update, you must associate the wait
            /// condition with a new WaitConditionHandle resource. Do not reuse an old wait condition handle that
            /// has already been defined in the template. If you reuse a wait condition handle, the wait condition
            /// might evaluate old signals from a previous create or update stack command.
            /// Required: Yes
            /// Type: String
            /// Update requires: Updates are not supported.
            /// </summary>
			public Union<string, IntrinsicFunction> Handle { get; set; }

            /// <summary>
            /// Timeout
            /// The length of time (in seconds) to wait for the number of signals that the Count property specifies.
            /// Timeout is a minimum-bound property, meaning the timeout occurs no sooner than the time you specify,
            /// but can occur shortly thereafter. The maximum time that can be specified for this property is 12
            /// hours (43200 seconds).
            /// Required: Yes
            /// Type: String
            /// Update requires: Updates are not supported.
            /// </summary>
			public Union<string, IntrinsicFunction> Timeout { get; set; }

        }

        public string Type { get; } = "AWS::CloudFormation::WaitCondition";

        public WaitConditionProperties Properties { get; } = new WaitConditionProperties();

        /// <summary>
        /// Associate the CreationPolicy attribute with a resource to prevent its status from reaching create complete until AWS CloudFormation receives
        /// a specified number of success signals or the timeout period is exceeded. To signal a resource, you can use the cfn-signal helper script or 
        /// SignalResource API. AWS CloudFormation publishes valid signals to the stack events so that you track the number of signals sent.
        /// The creation policy is invoked only when AWS CloudFormation creates the associated resource.Currently, the only AWS CloudFormation resources 
        /// that support creation policies are AWS::AutoScaling::AutoScalingGroup, AWS::EC2::Instance, and AWS::CloudFormation::WaitCondition.
        /// Use the CreationPolicy attribute when you want to wait on resource configuration actions before stack creation proceeds. For example, if you 
        /// install and configure software applications on an EC2 instance, you might want those applications to be running before proceeding. In such 
        /// cases, you can add a CreationPolicy attribute to the instance, and then send a success signal to the instance after the applications are 
        /// installed and configured.
        /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-attribute-creationpolicy.html
        /// </summary>
        public CreationPolicy CreationPolicy { get; set; }

    }

	public static class WaitConditionAttributes
	{
        public static readonly ResourceAttribute<Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction>> Data = new ResourceAttribute<Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction>>("Data");
	}
}
