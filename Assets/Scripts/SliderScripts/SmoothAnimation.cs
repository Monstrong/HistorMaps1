using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.SliderScripts
{
    public class SmoothAnimation : MonoBehaviour
    {
        [Tooltip("скорость подъема")]
        [SerializeField] float liftSpeed = 1.0f;
        [Tooltip("высота подъема")]
        [SerializeField] float targetY = 1.0f;
        [SerializeField] Color targetColor = Color.white;
        private Renderer rend;
        private Color startColor;
        Vector3 defaultPos;
        Vector3 targetPos;
        bool isLifted = false;
        bool inDefaultPos = true;
        void Start()
        {
            rend = GetComponent<Renderer>();
            startColor = rend.material.color;
            defaultPos = transform.position;
            targetPos = new Vector3(transform.position.x, targetY, transform.position.z);
        }

        void Update()
        {
            if (isLifted)
            {
                Move(targetPos.y, targetColor);
            }
            else if (!inDefaultPos)
            {
                Move(defaultPos.y, startColor);
                if (Vector3.Distance(transform.position, defaultPos) < 0.001f)
                {
                    inDefaultPos = true;
                }
            }
        }
        public void Move(float y, Color color)
        {
            transform.position = new Vector3(transform.position.x,
                                                           Mathf.Lerp(transform.position.y, y, liftSpeed * Time.deltaTime),
                                                           transform.position.z);
            rend.material.color = Color.Lerp(rend.material.color, color, liftSpeed * Time.deltaTime);
        }
        public void Activate()
        {
            isLifted = true;
            inDefaultPos = false;
        }
        public void Deactivate()
        {
            isLifted = false;
        }
    }
}
