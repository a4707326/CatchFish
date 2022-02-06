using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GunMount : MonoBehaviour
{
    private Button Info_btn;
    private Button AddChips_btn;
    private Button ReduceChips_btn;
    private Text Chips_text;

    private int Chips = 5;
    private int ChangeCount = 5;


    void Awake()
    {
        Info_btn = GetComponent<Button>();
        AddChips_btn = transform.Find("AddChips_btn").GetComponent<Button>();
        ReduceChips_btn = transform.Find("ReduceChips_btn").GetComponent<Button>();
        Chips_text = transform.Find("Chips_image/Text").GetComponent<Text>();
    }

    // Start is called before the first frame update
    void Start()
    {
        Info_btn.onClick.AddListener(ShowInfoWindow);
        AddChips_btn.onClick.AddListener(AddChips);
        ReduceChips_btn.onClick.AddListener(ReduceChips);
    }


    void AddChips()
    {
        Chips += ChangeCount;
        Chips_text.text = Chips.ToString();
    }
    void ReduceChips()
    {
        Chips -= ChangeCount;
        Chips_text.text = Chips.ToString();
    }
    void ShowInfoWindow()
    {
        Debug.Log("ShowInfoWindow");
    }
}
