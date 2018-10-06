using Comformation.IntrinsicFunctions;

namespace Comformation
{
    public class CreationPolicy
    {
        public AutoScalingCreationPolicy AutoScalingCreationPolicy { get; set; }
        public ResourceSignal ResourceSignal { get; set; }
    }

    public class AutoScalingCreationPolicy
    {
        /// <summary>
        /// Specifies the percentage of instances in an Auto Scaling replacement update that must signal success for the update to succeed. 
        /// You can specify a value from 0 to 100. AWS CloudFormation rounds to the nearest tenth of a percent. For example, if you update 
        /// five instances with a minimum successful percentage of 50, three instances must signal success. If an instance doesn't send a 
        /// signal within the time specified by the Timeout property, AWS CloudFormation assumes that the instance wasn't created.
        /// Default: 100
        /// </summary>
        public Union<int, IntrinsicFunction> MinSuccessfulInstancesPercent { get; set; }
    }

    public class ResourceSignal
    {
        /// <summary>
        /// The number of success signals AWS CloudFormation must receive before it sets the resource status as CREATE_COMPLETE. If the 
        /// resource receives a failure signal or doesn't receive the specified number of signals before the timeout period expires, the 
        /// resource creation fails and AWS CloudFormation rolls the stack back.
        /// Default: 1
        /// </summary>
        public Union<int, IntrinsicFunction> Count { get; set; }

        /// <summary>
        /// The length of time that AWS CloudFormation waits for the number of signals that was specified in the Count property. The timeout
        /// period starts after AWS CloudFormation starts creating the resource, and the timeout expires no sooner than the time you specify 
        /// but can occur shortly thereafter. The maximum time that you can specify is 12 hours.
        /// The value must be in ISO8601 duration format, in the form: "PT#H#M#S", where each # is the number of hours, minutes, and seconds, 
        /// respectively. For best results, specify a period of time that gives your instances plenty of time to get up and running. A shorter 
        /// timeout can cause a rollback.
        /// Default: PT5M (5 minutes)
        /// </summary>
        public Union<string, IntrinsicFunction> Timeout { get; set; }
    }
}
