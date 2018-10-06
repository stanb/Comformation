namespace Comformation
{
    public static class TemplateItemExtensions
    {
        public static IntrinsicFunctions.Ref Ref(this ITemplateItem item)
        {
            return new IntrinsicFunctions.Ref(item.LogicalId);
        }
    }
}
