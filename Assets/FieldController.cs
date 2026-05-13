using UnityEngine;
using UnityEngine.EventSystems;

public class FieldController : MonoBehaviour, IPointerClickHandler
{
    LevelManager levelManager;
    void Start()
    {
        // znajdz obiekt w hierarchii o nazwie "LevelManager"
        // i przypisz jego komponent LevelManager do zmiennej levelManager
        levelManager = GameObject.Find("LevelManager").GetComponent<LevelManager>();
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        // Handle the click event
        Debug.Log("Field clicked!");
        //sprawdz czy rosliny ktore sa obiektami potomnymi sa gotowe do zebrania
        foreach (Transform child in transform)
        {
            CropController crop = child.GetComponent<CropController>();
            if (crop != null && crop.IsReady())
            {
                //jesli roslina jest gotowa do zebrania to zbierz ja
                Harvest();
                //usun rosliny z pola
                Destroy(child.gameObject);
            }
        }
    }
    void Harvest()
    {
        // Dodaj 10 pieniêdzy do poziomu
        levelManager.AddCash(10);
    }
}
