using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AutoReplay : MonoBehaviour
{
	float timer = 0;
	public Text info;
    // Start is called before the first frame update
    void Start()
    {
        if (EnemyController.EnemyKilled == 3)
	{
		info.text = "Congratulations \nYou Win!";
	}
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
	if (timer > 5)
	{
		Data.score = 0;
		EnemyController.EnemyKilled = 0;
		SceneManager.LoadScene("Gameplay");
	}
    }
}
