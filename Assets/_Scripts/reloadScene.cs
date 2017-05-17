using UnityEngine;
using Valve.VR;
using UnityEngine.SceneManagement;




public class reloadScene : MonoBehaviour {

    //private AsyncOperation scene;

    private Valve.VR.EVRButtonId gripButton = Valve.VR.EVRButtonId.k_EButton_Grip;
    private Valve.VR.EVRButtonId triggerButton = Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger;

    private SteamVR_Controller.Device controller { get { return SteamVR_Controller.Input((int)trackedObj.index); } }
    private SteamVR_TrackedObject trackedObj;

    void Start() {
        trackedObj = GetComponent<SteamVR_TrackedObject>();

        OpenVR.System.GetTrackedDeviceIndexForControllerRole(ETrackedControllerRole.RightHand);
        OpenVR.System.GetTrackedDeviceIndexForControllerRole(ETrackedControllerRole.LeftHand);

    }

    // Update is called once per frame
    void Update()
    {
        if (controller == null)
        {
            Debug.Log("Controller not initialized");
            return;
        }

        if (controller.GetPressDown(triggerButton))
        {
            Debug.Log("Trigger Down");

        }

        if (controller.GetPressUp(triggerButton))
        {
            Debug.Log("Trigger up");
            SceneManager.LoadScene("First");
        }


        if (controller.GetPressDown(gripButton))
        {
            print("gripped!");
        }

        if (controller.GetPressUp(gripButton))
        {
            print("ungripped!");
            
        }

    }


    

}
