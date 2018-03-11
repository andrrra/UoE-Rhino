using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetSize : MonoBehaviour {

    // Use this for initialization
    void Start () {

        RectTransform rt = gameObject.GetComponent<RectTransform>();

        int original_width = (int)rt.rect.width;
        int original_height = (int)rt.rect.height;

        int new_width = original_width, new_height = original_height;
        // first check if we need to scale width
        if (original_width < Screen.width) {
            //scale width to fit
            new_width = Screen.width * original_height / original_width;
            new_height = Screen.height * Screen.width / original_width;
        }

        // then check if we need to scale even with the new height
        if (original_height < Screen.height) {
            //scale height to fit instead
            new_height = Screen.height * original_width / original_height;
            new_width = Screen.width * Screen.height / original_height;
        }

        rt.sizeDelta = new Vector2 (new_width, new_height);
    }

}
