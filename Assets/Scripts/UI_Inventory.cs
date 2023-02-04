using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UI_Inventory : MonoBehaviour
{
    private Inventory inventory;
    private Transform seedSlotTemplate;
    private Transform seedSlotContainer;

    private void Awake()
    {
        seedSlotContainer = transform.Find("seedSlotContainer");
        seedSlotTemplate = seedSlotContainer.Find("seedSlotTemplate");
    }

    public void SetInventory(Inventory inventory)
    {
        this.inventory = inventory;
        RefreshInventoryItems();
    }

    private void RefreshInventoryItems()
    {
        int x = 0;
        int y = 0;
        float seedSlotCellSize = 30f;
        foreach (Item item in inventory.GetItemList())
        {
            RectTransform seedSlotRectTransform = Instantiate(seedSlotTemplate, seedSlotContainer).GetComponent<RectTransform>();
            seedSlotRectTransform.gameObject.SetActive(true);

            seedSlotRectTransform.anchoredPosition = new Vector2(x * seedSlotCellSize, y * seedSlotCellSize);
            Image image = seedSlotRectTransform.Find("Image").GetComponent<Image>();
            image.sprite = item.GetSprite();

            TextMeshProUGUI uiText = seedSlotRectTransform.Find("text").GetComponent<TextMeshProUGUI>();
            uiText.SetText(item.amount.ToString());

            x++;
            if (x > 1)
            {
                x = 0;
                y--;
            }
        }
    }
}
