using System;
using UnityEngine;

namespace TheLurkingDev.InputHandling
{
    public class ClickableSprite : MonoBehaviour
    {
        public static event Action<ClickableSprite> OnAnySpriteClicked = delegate { };

        private BoxCollider2D _collider;
        private Camera _mainCamera;

        public void HandleMouseClick(MouseButton mouseButton)
        {            
            if(IsMouseOverSprite())
            {
                Debug.Log("You clicked sprite with: " + mouseButton.ToString());
            }            
        }

        private void Awake()
        {
            _collider = GetComponent<BoxCollider2D>();
            _mainCamera = Camera.main;
            InputHandler.OnAnyMouseClick += HandleMouseClick;
        }

        private bool IsMouseOverSprite()
        {
            Vector2 mousePosition = _mainCamera.ScreenToWorldPoint(Input.mousePosition);

            if (_collider.OverlapPoint(mousePosition))
            {
                return true;
            }

            return false;
        }
    }
}
