using System;
using Microsoft.MixedReality.Toolkit.Utilities;
using TMPro;
using UnityEngine;

namespace HandPressDetectionDemo
{
    public class TapMenuController : MonoBehaviour
    {
        [SerializeField]
        private GameObject tap;

        private void Start()
        {
            tap.SetActive(false);
        }

        public void ButtonPressed(Handedness handedness)
        {
            if (handedness == Handedness.Right)
            {
                var scale = tap.transform.localScale;
                tap.transform.localScale = new Vector3(-scale.x, scale.y, scale.z);
            }
            gameObject.SetActive(false);
            tap.SetActive(true);
        }
    }
}
