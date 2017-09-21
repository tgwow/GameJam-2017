using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class EventoGeral : MonoBehaviour {

    public GameObject[] go;
    public string[] pergunta;
    public string[] botao1;
    public string[] botao2;
    public string[] botao3;
    public Text btnEscolha1;
    public Text btnEscolha2;
    public Text btnEscolha3;
    public Text txtPergunta;





    // Use this for initialization
    void Start () {
        int i = Random.Range(0, pergunta.Length);
        btnEscolha1.text = botao1[i];
        btnEscolha2.text = botao2[i];
        btnEscolha3.text = botao3[i];
        txtPergunta.text = pergunta[i];

    }

    public void Escolha1()
    {
		GameObject goBtn = GameObject.Find ("Escolha1") as GameObject;
		Text txt = goBtn.GetComponent<Text>();
		debitar(txt.text);
    }
	public void Escolha2()
	{
		GameObject goBtn = GameObject.Find ("Escolha2") as GameObject;
		Text txt = goBtn.GetComponent<Text>();
		debitar(txt.text);
	}
	public void Escolha3()
	{
		GameObject goBtn = GameObject.Find ("Escolha3") as GameObject;
		Text txt = goBtn.GetComponent<Text>();
		debitar(txt.text);
	}

	void debitar(string s){
		if (s == "") {
			GameManager.instance.money += 10;
			GameManager.instance.happy -= 10;

		}
		if (s == "Bicicleta  R$0,00") {
			GameManager.instance.money += 1;
			GameManager.instance.happy -= 1;
            SceneManager.LoadScene("vaca");
		}
		if (s == "Onibus R$ 10,00") {
			GameManager.instance.money += 2;
			GameManager.instance.happy -= 2;
            SceneManager.LoadScene("vaca");
        }
		if (s == "CarroR$ 30,00") {
            
			GameManager.instance.money += 3;
			GameManager.instance.happy -= 3;
            SceneManager.LoadScene("geleia");
        }
		if (s == "Podrão R$ 5,00") {
            
            GameManager.instance.money -= 5;
			GameManager.instance.happy -= 1;
            SceneManager.LoadScene("geleia");
        }
        if (s == "Marmita R$ 10,00")
        {
            GameManager.instance.money -= 10;
            GameManager.instance.happy -= 0;
            SceneManager.LoadScene("vaca");
        }
        if (s == "Marmita R$ 10,00")
        {
            GameManager.instance.money -= 10;
            SceneManager.LoadScene("vaca");
        }

        if (s == "Restaurante R$ 55,00")
        {
            GameManager.instance.money -= 55;
            GameManager.instance.happy += 1;
            SceneManager.LoadScene("geleia");
        }
        if (s == "Primo R$0,00")
        {
            GameManager.instance.money += 0;
            GameManager.instance.happy -= 10;
            SceneManager.LoadScene("geleia");
        }
        if (s == "Oficina R$100,00")
        {
            GameManager.instance.money -= 100;
            GameManager.instance.happy -= 10;
            SceneManager.LoadScene("vaca");
        }
        if (s == "semi-usado R$ 70,00")
        {
            GameManager.instance.money -=70;
            GameManager.instance.happy -= 10;
            SceneManager.LoadScene("geleia");
        }
        if (s == "Cinema R$50,00")
        {
            GameManager.instance.money -= 50;
            GameManager.instance.happy -= 10;
            SceneManager.LoadScene("vaca");
        }
        if (s == "Parque R$30")
        {
            GameManager.instance.money -= 30;
            GameManager.instance.happy -= 10;
            SceneManager.LoadScene("vaca");
        }
        if (s == "Restaurante R$70,00")
        {
            GameManager.instance.money -= 70;
            GameManager.instance.happy -= 10;
            SceneManager.LoadScene("geleia");
        }

        SceneManager.LoadScene("Escolha");

    }


    // Update is called once per frame
    void Update () {
		
	}
}
