using Sources.Code.GamePlay;
using UnityEngine;

namespace Sources.Code
{
    public class Main : MonoBehaviour
    {
        [SerializeField] private DragRoot _dragRoot;
        [SerializeField] private PlayerInput _playerInput;

        private void Start()
        {
            _playerInput.Init();
            _dragRoot.Init(_playerInput);
        }
    }
}
