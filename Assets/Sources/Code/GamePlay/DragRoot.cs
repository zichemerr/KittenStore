using UnityEngine;

namespace Sources.Code.GamePlay
{
    public class DragRoot : MonoBehaviour
    {
        [SerializeField] private Dragging _dragging;

        private PlayerInput _playerInput;
        
        public void Init(PlayerInput playerInput)
        {
            _dragging.Init();
            _playerInput = playerInput;
            playerInput.TouchStart += OnTouchStart;
            playerInput.Holding += OnHolding;
            playerInput.TouchEnd += OnTouchEnd;
        }
        
        private void OnTouchStart()
        {
            _dragging.StartDrag(_playerInput.MousePosition);
        }
        
        private void OnHolding()
        {
            _dragging.Drag(_playerInput.MousePosition);
        }
        
        private void OnTouchEnd()
        {
            _dragging.StopDrag();
        }
    }
}
