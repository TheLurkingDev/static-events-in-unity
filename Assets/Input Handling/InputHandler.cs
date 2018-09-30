using System;
using UnityEngine;

namespace TheLurkingDev.InputHandling
{
    public class InputHandler : MonoBehaviour
    {
        public static event Action<MouseButton> OnAnyMouseClick = delegate { };
        public static event Action<KeyCode> OnAnyKeyPressed = delegate { };

        private InputHandler _handler;

        private void Awake()
        {
            if (_handler == null)
            {
                _handler = GetComponent<InputHandler>();
            }
            else
            {
                GameObject.Destroy(this.gameObject);
            }
        }

        private void Update()
        {
            if (Input.anyKeyDown)
            {
                if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1) || Input.GetMouseButtonDown(2))
                {
                    var mouseButtonClicked = new MouseButton();

                    if (Input.GetMouseButtonDown(0))
                    {
                        mouseButtonClicked = MouseButton.Left;                        
                    }
                    if (Input.GetMouseButtonDown(1))
                    {
                        mouseButtonClicked = MouseButton.Right;
                    }
                    if (Input.GetMouseButtonDown(2))
                    {
                        mouseButtonClicked = MouseButton.Middle;
                    }

                    OnAnyMouseClick(mouseButtonClicked);
                }
                else
                {
                    KeyCode keyPressed = KeyCodeFinder.GetKeyCode();

                    Debug.Log("You pressed: " + keyPressed.ToString());
                    OnAnyKeyPressed(keyPressed);
                }
            }
        }
    }

    public static class KeyCodeFinder
    {
        public static KeyCode GetKeyCode()
        {
            /*
             * Letter keys 
             */

            if (Input.GetKeyDown(KeyCode.A))
            {
                return KeyCode.A;
            }
            if (Input.GetKeyDown(KeyCode.B))
            {
                return KeyCode.B;
            }
            if (Input.GetKeyDown(KeyCode.C))
            {
                return KeyCode.C;
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                return KeyCode.D;
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                return KeyCode.E;
            }
            if (Input.GetKeyDown(KeyCode.F))
            {
                return KeyCode.F;
            }
            if (Input.GetKeyDown(KeyCode.G))
            {
                return KeyCode.G;
            }
            if (Input.GetKeyDown(KeyCode.H))
            {
                return KeyCode.H;
            }
            if (Input.GetKeyDown(KeyCode.I))
            {
                return KeyCode.I;
            }
            if (Input.GetKeyDown(KeyCode.J))
            {
                return KeyCode.J;
            }
            if (Input.GetKeyDown(KeyCode.K))
            {
                return KeyCode.K;
            }
            if (Input.GetKeyDown(KeyCode.L))
            {
                return KeyCode.L;
            }
            if (Input.GetKeyDown(KeyCode.M))
            {
                return KeyCode.M;
            }
            if (Input.GetKeyDown(KeyCode.N))
            {
                return KeyCode.N;
            }
            if (Input.GetKeyDown(KeyCode.O))
            {
                return KeyCode.O;
            }
            if (Input.GetKeyDown(KeyCode.P))
            {
                return KeyCode.P;
            }
            if (Input.GetKeyDown(KeyCode.Q))
            {
                return KeyCode.Q;
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                return KeyCode.R;
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                return KeyCode.S;
            }
            if (Input.GetKeyDown(KeyCode.T))
            {
                return KeyCode.T;
            }
            if (Input.GetKeyDown(KeyCode.U))
            {
                return KeyCode.U;
            }
            if (Input.GetKeyDown(KeyCode.V))
            {
                return KeyCode.V;
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                return KeyCode.W;
            }
            if (Input.GetKeyDown(KeyCode.X))
            {
                return KeyCode.X;
            }
            if (Input.GetKeyDown(KeyCode.Y))
            {
                return KeyCode.Y;
            }
            if (Input.GetKeyDown(KeyCode.Z))
            {
                return KeyCode.Z;
            }

            /*
             * Numbers
             */
            if (Input.GetKeyDown(KeyCode.Alpha0))
            {
                return KeyCode.Alpha0;
            }
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                return KeyCode.Alpha1;
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                return KeyCode.Alpha2;
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                return KeyCode.Alpha3;
            }
            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                return KeyCode.Alpha4;
            }
            if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                return KeyCode.Alpha5;
            }
            if (Input.GetKeyDown(KeyCode.Alpha6))
            {
                return KeyCode.Alpha6;
            }
            if (Input.GetKeyDown(KeyCode.Alpha7))
            {
                return KeyCode.Alpha7;
            }
            if (Input.GetKeyDown(KeyCode.Alpha8))
            {
                return KeyCode.Alpha8;
            }
            if (Input.GetKeyDown(KeyCode.Alpha9))
            {
                return KeyCode.Alpha9;
            }

            /*
             * Arrow keys
             */
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                return KeyCode.UpArrow;
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                return KeyCode.RightArrow;
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                return KeyCode.DownArrow;
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                return KeyCode.LeftArrow;
            }

            /*
             *  Command keys
             */
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                return KeyCode.Escape;
            }
            if (Input.GetKeyDown(KeyCode.Delete))
            {
                return KeyCode.Delete;
            }
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                return KeyCode.Tab;
            }
            if (Input.GetKeyDown(KeyCode.Home))
            {
                return KeyCode.Home;
            }
            if (Input.GetKeyDown(KeyCode.End))
            {
                return KeyCode.End;
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                return KeyCode.Space;
            }            

            /*
             *  Option keys
             */
            if (Input.GetKeyDown(KeyCode.LeftControl))
            {
                return KeyCode.LeftControl;
            }
            if (Input.GetKeyDown(KeyCode.RightControl))
            {
                return KeyCode.RightControl;
            }
            if (Input.GetKeyDown(KeyCode.LeftAlt))
            {
                return KeyCode.LeftAlt;
            }
            if (Input.GetKeyDown(KeyCode.RightAlt))
            {
                return KeyCode.RightAlt;
            }
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                return KeyCode.LeftShift;
            }
            if (Input.GetKeyDown(KeyCode.RightShift))
            {
                return KeyCode.RightShift;
            }

            return KeyCode.None;
        }
    }

    public enum MouseButton
    {
        Left = 0,
        Right = 1,
        Middle = 2
    }
}

