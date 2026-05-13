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
        Harvest();
    }
    void Harvest()
    {
        // Dodaj 10 pieniêdzy do poziomu
        levelManager.AddCash(10);
    }
}
