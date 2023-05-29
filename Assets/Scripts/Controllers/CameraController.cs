using Cinemachine;
using UnityEngine;


namespace Bario.Controllers
{
    public class CameraController : BaseController
    {
        public CameraController(GameObject player, GameConfig gameConfig)
        {
            var virtualCamera = GetVirtualCamera(gameConfig);
            virtualCamera.Follow = player.transform;
        }

        private CinemachineVirtualCamera GetVirtualCamera(GameConfig gameConfig)
        {
            var go = GameObject.Instantiate(gameConfig.VirtualCameraPrefab);
            go.TryGetComponent<CinemachineVirtualCamera>(out var virtualCamera);
            AddGameObject(go);
            return virtualCamera;
        }
    }
}