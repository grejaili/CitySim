using UnityEngine;
using UnityEngine.UIElements;

public class InteractionManager : MonoBehaviour
{
    public static InteractionManager instance;

    public InventoryUI playerInventory;
    public InventoryUI npcInventory;
    public ItensInUse itensInUse;
    public GameObject tradePanel;
  

    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }

    public void OpenClosePlayerInventory()
    {
        playerInventory.gameObject.SetActive(!playerInventory.gameObject.activeSelf);
        itensInUse.gameObject.SetActive(playerInventory.gameObject.activeSelf);
    }

    public void OpenCloseNPCInventory()
    {
        if (playerInventory.gameObject.activeSelf.Equals(false))
        {
            playerInventory.gameObject.SetActive(true);
        }

        npcInventory.gameObject.SetActive(!npcInventory.gameObject.activeSelf);
    }

    public void OpenCloseNPCInventory(bool aux)
    {
        playerInventory.gameObject.SetActive(false);
        npcInventory.gameObject.SetActive(aux);
    }

  
    
    
}