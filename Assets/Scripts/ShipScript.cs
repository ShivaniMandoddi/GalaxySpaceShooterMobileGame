using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShipScript : MonoBehaviour
{
    #region PUBLIC VARIABLES
    public float rotationSpeed=10f; //   rotation of ship in degrees per second.
    public float movementSpeed=2f; // the movement of ship by force applied in second
    #endregion
    #region PRIVATE VARIABLES
    private bool isRotating = false;
    private const string TURN_COROUTINE_FUNCTION = "Turn_RotateandMoveTowardsTap";
    #endregion
    #region MONOBEHAVIOUR METHODS
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnEnable() // When gameobject is active, then we are subscribing 
    {
        MyMobileGalaxyShooter.UserInputHandler.OnTouchAction += TowardsTouch;
    }
    private void OnDisable()// When gameobject is inactive, then we are desubscribing 
    {
        MyMobileGalaxyShooter.UserInputHandler.OnTouchAction -= TowardsTouch;
    }

    #endregion
    #region MY PUBLIC METHODS
    public void TowardsTouch(Touch touch)
    {
        Vector3 worldTouchPosition=Camera.main.ScreenToWorldPoint(touch.position); //It converts pixel coordinates to world coordinates
        StopCoroutine(TURN_COROUTINE_FUNCTION);
        StartCoroutine(TURN_COROUTINE_FUNCTION,worldTouchPosition);
    }
    IEnumerator Turn_RotateandMoveTowardsTap(Vector3 tempPoint)
    {
        isRotating = true;
        tempPoint = tempPoint - this.transform.position; // difference between touch position and current ship position
        tempPoint.z = transform.position.z; // Assigning z value of  ship position to touch position
        transform.position = tempPoint; 
        Quaternion startRotation = this.transform.rotation; // the rotation start point
        Quaternion endRotation = Quaternion.LookRotation(tempPoint, Vector3.up); // This rotation look at touchpoint in up direction
        //Need to rework on it
        float time = Quaternion.Angle(startRotation, endRotation)/rotationSpeed; //Angle between two rotations
        for (float i = 0; i < time; i=i+Time.deltaTime)
        {

            transform.rotation = Quaternion.Slerp(startRotation, endRotation, i);
        }
        transform.rotation = endRotation; // We need to put shoot functionality here
        isRotating = false;

        yield return (null);
    }
    #endregion
    #region MY PRIVATE METHODS

    #endregion

}
