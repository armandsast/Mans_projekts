using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class NameScript : MonoBehaviour
{
    private string text;

    private string age;
    public GameObject scroolText ;
    public GameObject inputFieldName;
    public GameObject inputFieldAge;
    public GameObject outputField;

    public Text scroolTextObject;
   
    public void GetText() {
  
        text = inputFieldName.GetComponent<TMP_InputField>().text;

        age = inputFieldAge.GetComponent<TMP_InputField>().text;
        
        if (int.TryParse(age, out int result))
        {
            int vecums = 2026 - result;
            outputField.GetComponent<TMP_Text>().text = text + " ir " + vecums + " gadus vecs!";
        }
        else{
        outputField.GetComponent<TMP_Text>().text = "ievadīts nepareizs dzimšanas gads";

        }
    }
    public void ChangeText(int x)
    {
        if(x==0){
            scroolTextObject.text = "";
            scroolTextObject.text = "Markuss ir enerģisks un vienmēr kustībā. Viņam mugurā ir koši zils krekliņš ar dzeltenu zvaigzni, kas lieliski piestāv viņa dzīvespriecīgajai dabai. Markuss nevar iedomāties savu dienu bez futbola vai skriešanās ar draugiem.";
        }
        else
        {
            scroolTextObject.text = "";
            scroolTextObject.text = "Tomass turpretī ir mierīgāks un aizraujas ar dabas pētīšanu. Viņš izvēlas praktisku apģērbu, piemēram, zaļu t-kreklu ar savu mīļāko dinozauru. Tomass bieži pavada laiku dārzā, meklējot interesantus akmeņus vai vērojot kukaiņus.";
        }
    }




}
