using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Comformation
{
    /// <summary>
    /// Use the optional Parameters section to customize your templates.
    /// Parameters enable you to input custom values to your template each time you create or update a stack.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/parameters-section-structure.html
    /// </summary>
    [JsonConverter(typeof(TemplateItemsConverter))]
    public class Parameters : List<Parameter>
    {
    }

    public class Parameter : ITemplateItem
    {
        public string LogicalId { get; set;  }

        /// <summary>
        /// A regular expression that represents the patterns to allow for String types
        /// </summary>
        public string AllowedPattern { get; set; }
        
        /// <summary>
        /// An array containing the list of values allowed for the parameter.
        /// </summary>
        public object[] AllowedValues { get; set; }
        
        /// <summary>
        /// A string that explains a constraint when the constraint is violated. For example, without a constraint description, a parameter that has an allowed pattern of [A-Za-z0-9]+ displays the following error message when the user specifies an invalid value:
        /// Malformed input-Parameter MyParameter must match pattern [A-Za-z0-9]+
        /// By adding a constraint description, such as must only contain upper and lowercase letters, and numbers, you can display the following customized error message:
        /// Malformed input-Parameter MyParameter must only contain upper and lower case letters and numbers
        /// </summary>
        public string ConstraintDescription { get; set; }
        
        /// <summary>
        /// A value of the appropriate type for the template to use if no value is specified when a stack is created. If you define constraints for the parameter, you must specify a value that adheres to those constraints.
        /// </summary>
        public object Default { get; set; }
        
        /// <summary>
        /// A string of up to 4000 characters that describes the parameter.
        /// </summary>
        [MaxLength(4000)]
        public string Description { get; set; }
        
        /// <summary>
        /// An integer value that determines the largest number of characters you want to allow for String types.
        /// </summary>
        public int? MaxLength { get; set; }
        
        /// <summary>
        /// A numeric value that determines the largest numeric value you want to allow for Number types.
        /// </summary>
        public long? MaxValue { get; set; }
        
        /// <summary>
        /// An integer value that determines the smallest number of characters you want to allow for String types.
        /// </summary>
        public int? MinLength { get; set; }
        
        /// <summary>
        /// A numeric value that determines the smallest numeric value you want to allow for Number types.
        /// </summary>
        public long? MinValue { get; set; }
        
        /// <summary>
        /// The data type for the parameter (DataType).
        /// </summary>
        public ParameterType Type { get; set; }

    }
}
