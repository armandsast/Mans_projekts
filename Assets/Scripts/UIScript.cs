using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public GameObject[] cepures;
    public GameObject[] krekli;
     public GameObject[] bikses;
      public GameObject[] apavi;
    public GameObject imageField;
    public Sprite[] sprites;
    public GameObject scaleYslider;
    public GameObject scaleXslider;



public void CepuresSetActive(bool state)
    {
        foreach (GameObject item in cepures)
        {
            if (item != null)
            {
                item.SetActive(state);
            }
        }
    }



public void KrekliSetActive(bool state)
    {
        foreach (GameObject item in krekli)
        {
            if (item != null)
            {
                item.SetActive(state);
            }
        }
    }

public void BiksesSetActive(bool state)
    {
        foreach (GameObject item in bikses)
        {
            if (item != null)
            {
                item.SetActive(state);
            }
        }
    }

public void ApaviSetActive(bool state)
    {
        foreach (GameObject item in apavi)
        {
            if (item != null)
            {
                item.SetActive(state);
            }
        }
    }


    public void ChangeSprite(int val) {
        imageField.GetComponent<Image>().sprite = sprites[val];
    }

    public void ScaleX() {
        float currentValue = scaleXslider.GetComponent<Slider>().value;
        imageField.transform.localScale = new Vector2(1f * currentValue, 1f );
    }
        public void ScaleY() {
        float currentValue = scaleYslider.GetComponent<Slider>().value;
        imageField.transform.localScale = new Vector2(1f, 1f * currentValue);
    }
}
