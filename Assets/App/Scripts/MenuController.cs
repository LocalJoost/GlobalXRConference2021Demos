using Microsoft.MixedReality.Toolkit.Utilities;
using TMPro;
using UnityEngine;

namespace HandPressDetectionDemo
{
    public class MenuController : MonoBehaviour
    {
        [SerializeField]
        private TextMeshPro displayText;
        
        public void ButtonOnePressed(Handedness handedness)
        {
            displayText.text = $"Button 1 pressed - {handedness}";
        }
        
        public void ButtonTwoPressed(Handedness handedness)
        {
            displayText.text = $"Button 2 pressed - {handedness}";
        }
    }
}
