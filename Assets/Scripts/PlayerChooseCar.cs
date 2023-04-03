using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChooseCar : MonoBehaviour
{
    public static PlayerChooseCar Instance;
    [SerializeField] GameObject[] cars;
    public int index = 0;
    // Start is called before the first frame update
    void Start()
    {
        Instance = GetComponent<PlayerChooseCar>(); ;
        ChooseCar();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChooseCar()
    {
        for (int i = 0; i < cars.Length; i++)
        {
            Debug.Log("Index: " + this.index);
            if (i == Data.index)
            {
                
                cars[i].SetActive(true);
            } else
            {
                cars[i].SetActive(false);
            }
        }
    }

    
}
