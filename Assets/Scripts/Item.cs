using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {

    private Item itemToCompare;

    private Vector2 currentTouchPosition;

    private bool canMove;

    public ItemsEnum ItemType;

    public Collider2D myCollider;

    public Vector2 StartingPosition;

	// Use this for initialization
	void Start ()
    {
        StartingPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.touchCount > 0)
        {
            currentTouchPosition = Input.GetTouch(0).position;

            switch (Input.GetTouch(0).phase)
            {
                case TouchPhase.Began:
                    if (myCollider == Physics2D.OverlapPoint(currentTouchPosition))
                    {
                        canMove = true;
                    }
                    break;
                case TouchPhase.Moved:
                    if (canMove)
                    {
                        transform.position = currentTouchPosition;
                    }
                    break;
                case TouchPhase.Ended:
                    canMove = false;

                    if (itemToCompare != null)
                    {
                        if (ItemType == itemToCompare.ItemType)
                        {
                            //Riportare a null l'ItemType di quest'oggetto, riportarlo alla posizione iniziale e trasformare l'oggetto colliso in quello successivo
                        }
                        else if (itemToCompare.ItemType != ItemsEnum.Null_Item)
                        {
                            Vector2 tmpPosition = StartingPosition;

                            StartingPosition = itemToCompare.StartingPosition;
                            transform.position = StartingPosition;
                            itemToCompare.StartingPosition = tmpPosition;
                            itemToCompare.transform.position = itemToCompare.StartingPosition;
                        }
                        else
                        {
                            transform.position = StartingPosition;
                        }
                    }
                    break;
            }
        }
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        itemToCompare = collision.gameObject.GetComponent<Item>();
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        itemToCompare = null;
    }
}
