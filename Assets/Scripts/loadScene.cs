using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScene : MonoBehaviour
{
   public void pressButton()
   {
      SceneManager.LoadScene(1);
   }
}
