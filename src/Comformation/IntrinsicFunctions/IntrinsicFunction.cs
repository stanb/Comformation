using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Comformation.IntrinsicFunctions
{
    [JsonConverter(typeof(IntrinsicFunctionConverter))]
    public abstract class IntrinsicFunction
    {
        protected JToken Token;

        public virtual JToken ToJson()
        {
            return Token;
        }

        public override string ToString()
        {
            return Token.ToString();
        }
    }
}
