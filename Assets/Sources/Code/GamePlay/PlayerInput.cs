using System;
using UnityEngine;

namespace Sources.Code.GamePlay
{
    public class PlayerInput : MonoBehaviour
    {
        public event Action TouchEnd;
        public event Action Holding;
        public event Action TouchStart;

        public Vector3 MousePosition
        {
            get
            {
                Vector3 mousePosition = Input.mousePosition;
                mousePosition.z = 0f;
                
                return mousePosition;
            }
        }
        
        public void Init()
        {
            
        }
        
        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                TouchStart?.Invoke();
                return;
            }
            
            if (Input.GetMouseButton(0))
            {
                Holding?.Invoke();
                return;
            }
            
            if (Input.GetMouseButtonUp(0))
            {
                TouchEnd?.Invoke();
            }
        }
    }
}