using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public GameObject cepures;
    public GameObject krekls;
     public GameObject bikses;
      public GameObject apavi;
    public GameObject imageField;
    public Sprite[] sprites;
    public GameObject scaleYslider;
    public GameObject scaleXslider;


    public void ToggleBean (bool val) {
        cepures.SetActive(val);

    }

    public void ToggleTeddy (bool val) {
        krekls.SetActive(val);
    }

    public void ToggleGranny (bool val) {
        bikses.SetActive(val);
    }

    public void ToggleCar (bool val) {
        apavi.SetActive(val);
    }

    public void Flip(int val) {
        imageField.transform.localScale = new Vector2(val, 1);
    }

    public void ChangeSprite(int val) {
        imageField.GetComponent<Image>().sprite = sprites[val];
    }

    public void Rotate() {
        float currentValue = scaleYslider.GetComponent<Slider>().value;
        imageField.transform.rotation = Quaternion.Euler(0, 0, currentValue * 360);
    }

    public void Scale() {
        float currentValue = scaleXslider.GetComponent<Slider>().value;
        imageField.transform.localScale = new Vector2(1f * currentValue, 1f * currentValue);
    }
}
