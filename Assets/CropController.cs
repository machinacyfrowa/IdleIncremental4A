using UnityEngine;

public class CropController : MonoBehaviour
{
    GameObject model;
    float growth; //wyroœniêcie od 0 do 1
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //przypisz pierwszy obiekt potomny jako model roœliny
        model = transform.GetChild(0).gameObject;
        growth = 0.01f; //bardzo ma³a ale nie zerowa
    }
    // Update is called once per frame
    void Update()
    {
        if (growth < 1f)
        {
            //dodaj wzost - 0.1 na sekundê
            growth += Time.deltaTime * 0.1f; //roœnie o 0.1 na sekundê
            //growth /2 bo tymczasowy model jest 2 razy wiêkszy ni¿ roœlina
            model.transform.localScale = new Vector3(growth / 2, growth / 2, growth / 2);
        }
    }
    public bool IsReady()
    {
        //zwraca true jeœli roœlina jest w pe³ni wyroœniêta
        return growth >= 1f;
    }
}