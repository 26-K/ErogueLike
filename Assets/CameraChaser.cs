using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChaser : MonoBehaviour
{
        public Transform localTarget;
        new Transform transform;
        Vector3 firstDistacne;

        private void Awake()
        {
            this.transform = base.transform;
            this.firstDistacne = transform.localPosition - localTarget.localPosition;
        }

        private void LateUpdate()
        {
            var p = localTarget.transform.localPosition;
            this.transform.localPosition = p + firstDistacne;
        }
    
}
