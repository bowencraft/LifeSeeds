using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Inventory : MonoBehaviour
{
    private Inventory inventory;
    private Transform seedSlotTemplate;
    private Transform seedSlotContainer;

    private void Awake()
    {
        seedSlotContainer = transform.Find("seeSlotContainer");
        seedSlotTemplate = seedSlotContainer.Find("seeSlotTemplate");
    }

    public void SetInventory(Inventory inventory)
    {
        this.inventory = inventory;
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
            x++;
            if (x > 4)
            {
                x = 0;
                y++;
            }
        }
    }
}
