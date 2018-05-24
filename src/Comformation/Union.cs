using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Comformation
{
    [JsonConverter(typeof(UnionConverter))]
    public abstract class UnionBase
    {
        private readonly object _value;

        protected UnionBase(object value)
        {
            _value = value;
        }

        public JToken ToJson()
        {
            return JToken.FromObject(_value);
        }
    }

    public class Union<T1, T2> : UnionBase
    {
        public Union(T1 value) : base(value) { }
        public Union(T2 value) : base(value) { }
        
        public static implicit operator Union<T1, T2>(T1 value) => new Union<T1, T2>(value);
        public static implicit operator Union<T1, T2>(T2 value) => new Union<T1, T2>(value);
    }

    public class Union<T1, T2, T3> : UnionBase
    {
        public Union(T1 value) : base(value) { }
        public Union(T2 value) : base(value) { }
        public Union(T3 value) : base(value) { }

        public static implicit operator Union<T1, T2, T3>(T1 value) => new Union<T1, T2, T3>(value);
        public static implicit operator Union<T1, T2, T3>(T2 value) => new Union<T1, T2, T3>(value);
        public static implicit operator Union<T1, T2, T3>(T3 value) => new Union<T1, T2, T3>(value);
    }

    public class Union<T1, T2, T3, T4> : UnionBase
    {
        public Union(T1 value) : base(value) { }
        public Union(T2 value) : base(value) { }
        public Union(T3 value) : base(value) { }
        public Union(T4 value) : base(value) { }

        public static implicit operator Union<T1, T2, T3, T4>(T1 value) => new Union<T1, T2, T3, T4>(value);
        public static implicit operator Union<T1, T2, T3, T4>(T2 value) => new Union<T1, T2, T3, T4>(value);
        public static implicit operator Union<T1, T2, T3, T4>(T3 value) => new Union<T1, T2, T3, T4>(value);
        public static implicit operator Union<T1, T2, T3, T4>(T4 value) => new Union<T1, T2, T3, T4>(value);
    }

    public class Union<T1, T2, T3, T4, T5> : UnionBase
    {
        public Union(T1 value) : base(value) { }
        public Union(T2 value) : base(value) { }
        public Union(T3 value) : base(value) { }
        public Union(T4 value) : base(value) { }
        public Union(T5 value) : base(value) { }

        public static implicit operator Union<T1, T2, T3, T4, T5>(T1 value) => new Union<T1, T2, T3, T4, T5>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5>(T2 value) => new Union<T1, T2, T3, T4, T5>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5>(T3 value) => new Union<T1, T2, T3, T4, T5>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5>(T4 value) => new Union<T1, T2, T3, T4, T5>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5>(T5 value) => new Union<T1, T2, T3, T4, T5>(value);
    }

    public class Union<T1, T2, T3, T4, T5, T6> : UnionBase
    {
        public Union(T1 value) : base(value) { }
        public Union(T2 value) : base(value) { }
        public Union(T3 value) : base(value) { }
        public Union(T4 value) : base(value) { }
        public Union(T5 value) : base(value) { }
        public Union(T6 value) : base(value) { }

        public static implicit operator Union<T1, T2, T3, T4, T5, T6>(T1 value) => new Union<T1, T2, T3, T4, T5, T6>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5, T6>(T2 value) => new Union<T1, T2, T3, T4, T5, T6>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5, T6>(T3 value) => new Union<T1, T2, T3, T4, T5, T6>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5, T6>(T4 value) => new Union<T1, T2, T3, T4, T5, T6>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5, T6>(T5 value) => new Union<T1, T2, T3, T4, T5, T6>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5, T6>(T6 value) => new Union<T1, T2, T3, T4, T5, T6>(value);
    }

    public class Union<T1, T2, T3, T4, T5, T6, T7> : UnionBase
    {
        public Union(T1 value) : base(value) { }
        public Union(T2 value) : base(value) { }
        public Union(T3 value) : base(value) { }
        public Union(T4 value) : base(value) { }
        public Union(T5 value) : base(value) { }
        public Union(T6 value) : base(value) { }
        public Union(T7 value) : base(value) { }

        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7>(T1 value) => new Union<T1, T2, T3, T4, T5, T6, T7>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7>(T2 value) => new Union<T1, T2, T3, T4, T5, T6, T7>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7>(T3 value) => new Union<T1, T2, T3, T4, T5, T6, T7>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7>(T4 value) => new Union<T1, T2, T3, T4, T5, T6, T7>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7>(T5 value) => new Union<T1, T2, T3, T4, T5, T6, T7>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7>(T6 value) => new Union<T1, T2, T3, T4, T5, T6, T7>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7>(T7 value) => new Union<T1, T2, T3, T4, T5, T6, T7>(value);
    }

    public class Union<T1, T2, T3, T4, T5, T6, T7, T8> : UnionBase
    {
        public Union(T1 value) : base(value) { }
        public Union(T2 value) : base(value) { }
        public Union(T3 value) : base(value) { }
        public Union(T4 value) : base(value) { }
        public Union(T5 value) : base(value) { }
        public Union(T6 value) : base(value) { }
        public Union(T7 value) : base(value) { }
        public Union(T8 value) : base(value) { }

        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8>(T1 value) => new Union<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8>(T2 value) => new Union<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8>(T3 value) => new Union<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8>(T4 value) => new Union<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8>(T5 value) => new Union<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8>(T6 value) => new Union<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8>(T7 value) => new Union<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8>(T8 value) => new Union<T1, T2, T3, T4, T5, T6, T7, T8>(value);
    }

    public class Union<T1, T2, T3, T4, T5, T6, T7, T8, T9> : UnionBase
    {
        public Union(T1 value) : base(value) { }
        public Union(T2 value) : base(value) { }
        public Union(T3 value) : base(value) { }
        public Union(T4 value) : base(value) { }
        public Union(T5 value) : base(value) { }
        public Union(T6 value) : base(value) { }
        public Union(T7 value) : base(value) { }
        public Union(T8 value) : base(value) { }
        public Union(T9 value) : base(value) { }

        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T1 value) => new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T2 value) => new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T3 value) => new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T4 value) => new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T5 value) => new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T6 value) => new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T7 value) => new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T8 value) => new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T9 value) => new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
    }
}
