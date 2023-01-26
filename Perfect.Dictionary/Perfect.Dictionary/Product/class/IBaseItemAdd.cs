public enum ItemType
{
    Basic,
    Standard,
    Advanced,
    Professtion,
    Enterprise,
    Extra
}
namespace Perfect.Dictionary
{
    public abstract class IBaseItemAdd
    {
        public ItemType Itemtype;
    }
}