using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Admon_Buttons : MonoBehaviour
{
    /*------------------------------------------------------*/
    /* BOTONES DEL MENU PRINCIPAL */

    //Abre la escena Jugar
    public void BotonJugar(){
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }

    public function Button_Exit(){
        UnityEngine.Application.Quit();
    }
}
