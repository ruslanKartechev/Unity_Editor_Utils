using System;
using UnityEditor;
using UnityEngine;

namespace EditorUtils
{
    public class GUIWindowExample : MonoBehaviour
    {
        
        public void Open()
        {
            MyCustomEditor.ShowMyEditor();
        }
        
        
        public void Close()
        {
                
        }
        
    }
}