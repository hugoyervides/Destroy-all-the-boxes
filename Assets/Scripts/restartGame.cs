using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartGame : MonoBehaviour {
    private void OnCollisionEnter(Collision col)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
