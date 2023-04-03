using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeImage : MonoBehaviour
{
    [SerializeField] Image[] carImages;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickButton(int pos)
    {
        for (int i = 0; i < carImages.Length; i++)
        {
            if (carImages[i].IsActive())
            {
                if (pos == 1 && i != carImages.Length - 1)
                {
                    carImages[i].gameObject.SetActive(false);
                    carImages[i + 1].gameObject.SetActive(true);
                    Data.index = i + 1;
                    break;
                }
                else if (pos == -1 && i != 0)
                {
                    carImages[i].gameObject.SetActive(false);
                    carImages[i - 1].gameObject.SetActive(true);
                    Data.index = i - 1;
                    break;
                }
            }
        }
    }
}
