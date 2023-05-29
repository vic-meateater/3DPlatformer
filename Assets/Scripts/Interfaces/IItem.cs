using Bario;
using System.Collections.Generic;

namespace Bario
{
    public interface IItem
    {
       int Id { get; set; }
       ItemInfo ItemInfo { get; set; }
    }
}
