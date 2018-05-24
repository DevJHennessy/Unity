using UnityEngine;
using System.Collections;

public class HeadsUpDisplay : MonoBehaviour
{
    private void OnGUI()
    {
        var style = new GUIStyle();
        style.fontSize = 35;
        style.font = Resources.Load<Font>("Fonts/AGENCYB");
        style.normal.textColor = Color.blue;
        GUI.contentColor = Color.blue;
        //Font.CreateDynamicFontFromOSFont("Agency FB", 20);
        GUI.Label(new Rect(15, 15, Screen.width, Screen.height), string.Format("<b>PowerUP: {0}</b>", PowerUpManager.PowerUpMeter.ToString()), style);

        GUI.Label(new Rect(15, 65, Screen.width, Screen.height), string.Format("<b>CoolDown: {0}</b>", CubeController.CoolCounter.ToString()), style);

    }
}