using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionZone : MonoBehaviour
{
    private GameObject collectedItem;
    private bool isItemCollected = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!isItemCollected && other.CompareTag("Collectible"))
        {
            collectedItem = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (collectedItem == other.gameObject)
        {
            collectedItem = null;
        }
    }

    private void Update()
    {
        if (collectedItem != null && collectedItem.transform.position == transform.position)
        {
            CollectItem();
        }
    }

    private void CollectItem()
    {
        Debug.Log("Item Collected!");
        Destroy(collectedItem);
        collectedItem = null;
        isItemCollected = true;
    }
}
