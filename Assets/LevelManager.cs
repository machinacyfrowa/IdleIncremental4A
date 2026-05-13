using TMPro;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    //obiekty wyœwietlaj¹cy iloœæ pieniêdzy na ekranie
    //pamiêtaj ¿eby go przypisaæ w edytorze
    public GameObject cashText;
    int cash = 0;

    void Update()
    {
        //aktualizuj licznik pieniêdzy na ekranie
        cashText.GetComponent<TextMeshProUGUI>().text = cash.ToString();
    }

    //funkcja dodaje okreœlon¹ iloœæ pieniêdzy do aktualnej sumy
    public void AddCash(int amount)
    {
        cash += amount;
    }
}
