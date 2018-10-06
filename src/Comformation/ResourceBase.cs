using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Comformation
{
    public abstract class ResourceBase : ITemplateItem
    {
        public string LogicalId { get; set; }

        /// <summary>
        /// With the DependsOn attribute you can specify that the creation of a specific resource follows another. When you add a DependsOn attribute to a 
        /// resource, that resource is created only after the creation of the resource specified in the DependsOn attribute.
        /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-attribute-dependson.html
        /// </summary>
        public Union<string, List<string>> DependsOn { get; set; }

        /// <summary>
        /// With the DeletionPolicy attribute you can preserve or (in some cases) backup a resource when its stack is deleted. You specify a DeletionPolicy 
        /// attribute for each resource that you want to control. If a resource has no DeletionPolicy attribute, AWS CloudFormation deletes the resource by 
        /// default.
        /// Note that this capability also applies to stack update operations that lead to resources being deleted from stacks. For example, if you remove 
        /// the resource from the stack template, and then update the stack with the template. This capability does not apply to resources whose physical 
        /// instance is replaced during stack update operations. For example, if you edit a resource's properties such that AWS CloudFormation replaces 
        /// that resource during a stack update.
        /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-attribute-deletionpolicy.html
        /// </summary>
        public DeletionPolicy? DeletionPolicy { get; set; }

        /// <summary>
        /// The Metadata attribute enables you to associate structured data with a resource. By adding a Metadata attribute to a resource, you can add data in 
        /// JSON or YAML to the resource declaration. In addition, you can use intrinsic functions (such as GetAtt and Ref), parameters, and pseudo parameters 
        /// within the Metadata attribute to add those interpreted values.
        /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-attribute-metadata.html
        /// </summary>
        public JToken Metadata { get; set; }
    }
    
    [JsonConverter(typeof(TemplateItemsConverter))]
    public class Resources : List<ResourceBase>
    {
        
    }
}
