using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] private GameObject[] cars;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCars());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnCars()
    {
        while(true)
        {
            yield return new WaitForSeconds(3f);
            int index = Random.Range(0, cars.Length);
            Instantiate(cars[index], new Vector3(Random.Range(-4.4f, 4.4f), Random.Range(7.6f, 10f), 0), cars[index].transform.rotation);
        }
    }
}
