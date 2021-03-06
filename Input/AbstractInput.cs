﻿using UnityEngine;

namespace Common
{
    public abstract class AbstractInput
    {
        public abstract float GetAxisHorizontal();
        public abstract void SetAxisHorizontal(float value);
        public abstract float GetAxisRawHorizontal();
        public abstract void SetAxisRawHorizontal(float value);
        public abstract float GetAxisVertical();
        public abstract void SetAxisVertical(float value);
        public abstract float GetAxisRawVertical();
        public abstract void SetAxisRawVertical(float value);
        
        public abstract bool GetKey(KeyCode key);
        public abstract bool GetKeyDown(KeyCode key);
        public abstract void SetKeyDown(KeyCode key);
        public abstract bool GetKeyUp(KeyCode key);
        public abstract void SetKeyUp(KeyCode key);

        public abstract bool GetButton(string buttonName);
        public abstract bool GetButtonDown(string buttonName);
        public abstract void SetButtonDown(string buttonName);
        public abstract bool GetButtonUp(string buttonName);
        public abstract void SetButtonUp(string buttonName);

        public abstract Vector3 GetMousePosition();
        public abstract void SetMousePosition(Vector3 position);
    }
}