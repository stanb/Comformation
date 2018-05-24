using System.Linq;

namespace Comformation
{
    public class ResourceAttribute
    {
        public string[] Name { get; }

        public ResourceAttribute(params string[] name)
        {
            Name = name;
        }
    }

    public class ResourceAttribute<T> : ResourceAttribute
    {
        public ResourceAttribute(params string[] name) : base(name) { }
    }
}
