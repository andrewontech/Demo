using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonTest : MonoBehaviour {
  //Create serializable field for our button and our cube
  public Button MyButton = null;
  public GameObject TargetCube = null;

  private void Start() {
    //Subscribe to the onclick of MyButton
    MyButton.onClick.AddListener(OnMyButtonClick);
  }

  private void OnMyButtonClick() {
    //Turn off TargetCube
    TargetCube.SetActive(false);
  }
}
