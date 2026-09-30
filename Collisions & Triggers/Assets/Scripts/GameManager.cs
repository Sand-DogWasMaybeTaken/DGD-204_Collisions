using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Variables//
    public GameObject collectable;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Respawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //make a function that spawns in a collectable
    public void Respawn()
    {
        //spawn a collectable at a random location
        Instantiate(collectable, new Vector2(Random.Range(-6f, 6f), Random.Range(-3f, 3f)), collectable.transform.rotation);
    }

}
