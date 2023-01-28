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
        [Header("Human")]
        public string name;
        public Sprite humanSprite;
        [Header("Description")]
        public GameObject[] yearsObject;
        [Space(60)]
        public Sprite[] images;
        [Space(60)]
        [TextArea]
        public string description;
    }
    public class SliderObjects : MonoBehaviour
    {
        [SerializeField] Slider mySlider;
        [SerializeField] YearsObject[] yearsObjects;
        [SerializeField] TMP_Text humanname;
        [SerializeField] TMP_Text description;
        [SerializeField] Image humanSprite;
        [SerializeField] Image sprite1;
        [SerializeField] Image sprite2;

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
                        SetValues(yearsObject);
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
        void SetValues(YearsObject yo)
        {
            humanname.text = yo.name;
            description.text = yo.description;
            humanSprite.sprite = yo.humanSprite;
            sprite1.sprite = yo.images[0];
            sprite2.sprite = yo.images[1];
        }
    }
 
}