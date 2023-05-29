using Bario;
using Bario.Interfaces;
using System;
using System.Collections.Generic;

namespace Bario.Controllers
{
    public static class UpdateController
    {
        private static List<IFixedUpdate> _fixedUpdatesControllers = new();
        public static List<IFixedUpdate> GetFixedUpdates => _fixedUpdatesControllers;

        public static void Add(BaseController controller)
        {
            if (controller is IFixedUpdate fixedUpdate)
            {
                _fixedUpdatesControllers.Add(fixedUpdate);
            }
        }

        public static void Remove(BaseController controller)
        {
            if (controller is IFixedUpdate fixedUpdate)
            {
                _fixedUpdatesControllers.Remove(fixedUpdate);
            }
        }
    }
}
