using System;
using UnityEngine;
using Vaniakit.ResourceManager;
public class EquipItem : ItemHolder
{
    [SerializeField] private GameObject showText;
  

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            showText.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            showText.SetActive(false);
    }

    private void Update()
    {
        if (showText.activeInHierarchy)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                givePlayerItem(true);
                Destroy(gameObject);
            }
        }
    }
}
