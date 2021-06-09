using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneManagerScript : MonoBehaviour
{
    bool DesativaPass = false;

    void Start()
    {
        DesativaPass = PersistentManagerScript.Instance.TerminouLab;
    }




}
