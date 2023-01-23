using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.SliderScripts
{
    [System.Serializable]
    public class YearsObject
    {
        public int yearStart;
        public int yearEnd;
        public GameObject[] yearsObject;
    }
    public class SliderObjects : MonoBehaviour
    {
        [SerializeField] Slider mySlider;
        [SerializeField] YearsObject[] yearsObjects;

        [SerializeField] TMP_Text yearText;
        private List<GameObject> objects = new List<GameObject>();
        void Start()
        {
            // подписываемся на слайдер
            mySlider.onValueChanged.AddListener(delegate { ValueChangeCheck(); });
        }
        /// <summary>
        /// В зависимости от старта и конца года, включаем или выключаем объекты
        /// </summary>
        void ValueChangeCheck()
        {
            objects.Clear();
            int value = (int)mySlider.value;
            yearText.text = (value-value%50).ToString();

            foreach (YearsObject yearsObject in yearsObjects)
            {
                if (value >= yearsObject.yearStart && value <= yearsObject.yearEnd)
                {
                    foreach (GameObject obj in yearsObject.yearsObject)
                    {
                        objects.Add(obj);
                        obj.GetComponent<SmoothAnimation>().Activate();
                    }
                }
                else
                {
                    foreach (GameObject obj in yearsObject.yearsObject)
                    {
                        if (!objects.Contains(obj))
                        {
                            obj.GetComponent<SmoothAnimation>().Deactivate();
                        }
                    }
                }
            }
        }
    }
}
 /* if (value < 1350) {yearText.text=1300}
            else if (value < 1400) { yearText.text = 1350}
            else if (value < 1450) { yearText.text = 1400}
            else if (value < 1500) { yearText.text = 1450}
            else if (value < 1550) { yearText.text = 1500}
            else if (value < 1600) { yearText.text = 1550}
            else if (value < 1650) { yearText.text = 1600}
            else if (value < 1700) { yearText.text = 1650}
            else if (value < 1750) { yearText.text = 1700}
            else if (value < 1800) { yearText.text = 1750}
            else if (value < 1850) { yearText.text = 1800}
            else if (value < 1900) { yearText.text = 1850}
            else if (value < 1950) { yearText.text = 1900}
            else if (value < 2000) { yearText.text = 1950}
            else { yearText.text = 2000} */