using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class ItemCounter : MonoBehaviour
{
    public TextMeshProUGUI itemCounter;
    public int itemAmount;
    public int itemTotalAm = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        itemCounter.text = itemAmount.ToString();
        if (itemAmount == itemTotalAm)
        {
            SceneManager.LoadScene("YouWin");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "item")
        {
            itemAmount ++;
            Destroy(other.gameObject);
        }
    }
}
