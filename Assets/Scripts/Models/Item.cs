using Bario.Interfaces;
namespace Bario
{
    public class Item : IItem
    {
        public int Id { get; set; }
        public ItemInfo ItemInfo { get; set; }
    }
}