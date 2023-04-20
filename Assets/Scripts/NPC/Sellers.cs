using UnityEngine;


public class Sellers : NPCController
{
    [SerializeField] private Inventory inventory;

    protected override void Interaction()
    {
        if (!_canInteract)
            return;
        OpenTradeWindow();
    }


    public void OpenTradeWindow()
    {
        InteractionManager.instance.OpenCloseNPCInventory();
    }

    protected override void OnTriggerEnter2D(Collider2D other)
    {
        base.OnTriggerEnter2D(other);
        InteractionManager.instance.npcInventory.inventoryReference = inventory;
        
    }

    protected override void OnTriggerExit2D(Collider2D other)
    {
        base.OnTriggerEnter2D(other);
        Debug.Log("exit trigger");
        _canInteract = false;
        InteractionManager.instance.OpenCloseNPCInventory(false);
        InteractionManager.instance.npcInventory.inventoryReference = null;
    }
}