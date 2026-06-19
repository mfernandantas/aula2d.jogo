using UnityEngine;
using UnityEngine.SceneManagement; // Linha obrigatória para controle de cenas!

public class MenuGerenciador : MonoBehaviour
{
    public void IniciarJogo()
    {
        // Substitua "NomeDaSuaFase" pelo nome exato da cena do seu jogo
        SceneManager.LoadScene("jogo");
    }
}