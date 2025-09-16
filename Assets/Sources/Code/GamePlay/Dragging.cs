using UnityEngine;

namespace Sources.Code.GamePlay
{
    public class Dragging : MonoBehaviour
    {
        private Vector2 _startPosition;
        private bool _isDragging; 
        
        public void Init()
        {

        }

        public void StartDrag(Vector3 mousePosition)
        {
            Vector2 position = Camera.main.ScreenToWorldPoint(mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(position, Vector2.zero);

            if (hit.collider == null)
                return;
            
            if (hit.collider.GetComponent<Dragging>()== false)
                return;
            
            _startPosition = transform.position;
            _isDragging = true;
        }
        
        public void Drag(Vector3 mousePosition)
        {
            if (_isDragging == false)
                return;
            
            Vector2 position = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = position;
        }
        
        public void StopDrag()
        {
            _isDragging = false;
            transform.position = _startPosition;
        }
    }
}