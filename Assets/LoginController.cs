using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginController : MonoBehaviour
{

    private const string Login = "Annimar";
    private const string Pass = "annimar";



    [SerializeField]
    private InputField usuarioField = null;
    [SerializeField]
    private InputField senhaField = null;
    [SerializeField]
    private Text feedbackmsg = null;
    [SerializeField]
    private Toggle rememberData = null;

   
    void Start()
    {
        usuarioField.text = Login;
        senhaField.text = Pass;
/*
        if (PlayerPrefs.HasKey("remember") && PlayerPrefs.GetInt("remember") == 1)
        {
            usuarioField.text = PlayerPrefs.GetString("rememberLogin");
            senhaField.text = PlayerPrefs.GetString("rememberPass");
        }*/

    }


    public void FazerLogin()
    {
        string usuario = usuarioField.text;
        string senha = senhaField.text;

       /* if (rememberData.isOn)
        {
            PlayerPrefs.SetInt("remember", 1);
            PlayerPrefs.SetString("rememberLogin", usuario);
            PlayerPrefs.SetString("rememberPass", senha)
        }*/

        if (usuario == Login && senha == Pass)
        {
            feedbackmsg.CrossFadeAlpha(100f, 0f, false);
            feedbackmsg.color = Color.green;
            feedbackmsg.text = "Login realizado com sucesso! \n Carregando...";
            StartCoroutine(CarregaScene());
        }
        else
        {
            feedbackmsg.CrossFadeAlpha(100f, 0f, false);
            feedbackmsg.color = Color.red;
            feedbackmsg.text = "Usuário ou senhas inválidos.";
            usuarioField.text = "";
            senhaField.text = "";
        }

    }

    IEnumerator CarregaScene()
    {
        yield return new WaitForSeconds(5);
        Application.LoadLevel("DesafioObjeto");
    }
}
