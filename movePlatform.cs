using UnityEngine;

public class movePlatform : MonoBehaviour
{
    [SerializeField]
    float rangeOfDrift = 15f;
    [SerializeField]
    float driftSpeed = 1f;
    bool forward = false;
    float currentPositionAxisSingular = 0;
    [SerializeField]
    string movementLine = "x";
    GameObject platform;

    Vector3 standardPosition;
    void Start()
    {
        platform = this.gameObject;
        standardPosition = platform.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (forward) {
            currentPositionAxisSingular = currentPositionAxisSingular + driftSpeed;
        }
        else if (!forward){
            currentPositionAxisSingular = currentPositionAxisSingular - driftSpeed;
        }
        if (Mathf.Abs(currentPositionAxisSingular) >= rangeOfDrift) {
            forward = !forward;
        }
        switch (movementLine) {
            
            case "x":
                platform.transform.position =  standardPosition + new Vector3(currentPositionAxisSingular, 0, 0);
                break;
            case "y":
                platform.transform.position = standardPosition + new Vector3(0, currentPositionAxisSingular, 0);
                break;
            case "z":
                platform.transform.position = standardPosition + new Vector3(0, 0, currentPositionAxisSingular);
                break;
        }
 
    }
}
