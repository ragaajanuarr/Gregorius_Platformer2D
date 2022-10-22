using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitOrNext : MonoBehaviour
{
	public string NameScene = "";
    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
	{
		Application.Quit();
	}
    }

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.tag.Equals("Player"))
		{
			SceneManager.LoadScene(NameScene);
		}
	}
}
