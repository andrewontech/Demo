using UnityEngine;

public class MovementTest : MonoBehaviour {
  #region Member Variables
  #region Snap
  //What we want to move
  public Transform Target = null;
  //What is the target position we want to snap too
  public Vector3 TargetPosition = Vector3.zero;
  //Should we update to target postion this frame
  public bool UpdatePosition = false;
  #endregion

  #region Directional Movement
  //Should we be moving
  public bool Move = false;
  //What direction will we be moving in
  public Vector3 MovementDirection = Vector3.zero;
  //What speed will we be moving
  public float MovementSpeed = 0;
  #endregion
  #endregion

  #region Unity Methods
  //Called every CPU frame
  private void Update() {
    #region Snap
    //Check to see if we should update our targets position
    if(UpdatePosition) {
      //Actually update position to target position
      Target.position = TargetPosition;
      //Reset our bool so it wont update next frame, we only want it 
      //to update the frame we check the box in the inspector. 
      UpdatePosition = false;
    }
    #endregion

    #region Directional Movement
    //Check if we should be moving the target every frame. 
    if(Move) {
      //Move the target in a certain direction every frame. The speed is 
      //multiplied by the time it took for the last frame to complete, 
      //this converts our speed to game units/second.
      Target.Translate(MovementDirection * MovementSpeed * Time.deltaTime);
    }
    #endregion
  }
  #endregion
}
