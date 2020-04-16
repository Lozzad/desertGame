using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class GlobalShaderVariables : MonoBehaviour {
    public GameObject moon;

    private void OnPreRender () {
        //camera pos for the global shader position
        Shader.SetGlobalVector ("_CamPos", this.transform.position);
        Shader.SetGlobalVector ("_CamRight", this.transform.right);
        Shader.SetGlobalVector ("_CamUp", this.transform.up);
        Shader.SetGlobalVector ("_CamForward", this.transform.forward);
        //position of the Moon
        Shader.SetGlobalVector ("_MoonPos", moon.transform.position);
    }
}