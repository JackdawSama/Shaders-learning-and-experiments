using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class USBReplacement_Controller : MonoBehaviour
{
    //replace shader
    public Shader m_replacementshader;

    private void OnEnable()
    {
        if(m_replacementshader != null)
        {
            // the camera will replace all the shaders in the scene with th replacement one of the "RenderType" configuration mus match in both the shader

            GetComponent<Camera>().SetReplacementShader(m_replacementshader, "RenderType");
        }
    }

    private void OnDisable()
    {
        GetComponent<Camera>().ResetReplacementShader();    
    }
}
