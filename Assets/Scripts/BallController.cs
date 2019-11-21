using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEditor;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour {
    public float speed = 0.2f, limitSpeed = 3f;
    public float stop = 0f;
    public Rigidbody rb;
    public static bool gameOver = false;
    public static int CoinCount;
    public static int HealthCount = 3;
    public Text coins;
    public Text health;
    public float timer;
    public AudioSource audioControl;
    public AudioClip coinSound;
    public string mycanvas;
    public static bool gameispause = false;
    public static int sceneNumber;
    public static bool stopMove = false;
    public Particles parti;
    

    void Start() {
        rb = GetComponent<Rigidbody>();

        rb.velocity = new Vector3(speed, 0, 0);

        StartCoroutine (HighSpeed ());


        audioControl = GetComponent<AudioSource>();

    }

    public void Update() {

        //Debug.Log(transform.eulerAngles.y);
        coins.text = CoinCount.ToString();
        health.text = "Health x" + HealthCount.ToString();
        /*if (Input.touchCount > 0) 
        {
            rb.velocity = new Vector3(speed,0,0);
        }
        if (Input.touchCount == 0) 
        {
            rb.velocity = new Vector3(0,0,speed);
        }*/


        if (!Physics.Raycast(transform.position, Vector3.down, 1) || HealthCount == 0)
        {
            gameOver = true;
            rb.useGravity = true;
        }
        if (gameOver == true)
        {
            GroundController.canCreate = false;
            timer = timer + 1 * Time.deltaTime;
            if (timer > 1.5f)
            {

                SceneManager.LoadScene("GameOver");
                timer = 0;

            }
        }

        if (stopMove == false)
        {
            Resume();
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0))
            {
                BallMove();
            }
        }
        else
        {
            
        }
        
        Debug.Log(stopMove);
        
    }


    public void Resume()
    {
        Time.timeScale = 1f;
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        gameispause = true;
    }

    public void AddSpeedx()
    {
        rb.velocity = new Vector3(speed, 0, 0);
    }

    public void AddSpeedz()
    {
        rb.velocity = new Vector3(0, 0, speed);
    }

    

	public void BallMove ()
	{
        //if (rb.velocity == new Vector3(0, 0, 0) && transform.eulerAngles == new Vector3(0,0,0))
        //{
        //    AddSpeedz();
        //}
        //else if (rb.velocity == new Vector3(0, 0, 0) && transform.eulerAngles == new Vector3(0, 90, 0))
        //{
        //    AddSpeedx();
        //}
        if (rb.velocity.x > 0)
        {
            rb.velocity = new Vector3(0, 0, speed);
        }
        else if (rb.velocity.z > 0)
        {
            rb.velocity = new Vector3(speed, 0, 0);

        }
    }

    //fungsi untuk menampilkan pertanyaan
    //void LoadQuestion()
    //{
    //    Application.loadLevel("");
    //}
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Coin")
		{
			Destroy(other.gameObject);
			CoinCount++;
			audioControl.PlayOneShot(coinSound);
            SelectScene();
            //Debug.Log(sceneNumber);
		}
	}
	IEnumerator HighSpeed()
	{
		while(!gameOver)
		{
			yield return new WaitForSeconds (2);
			if(speed <= limitSpeed)
			{
				speed += 0.2f;
			}

		}
	}

    public void ShowScene(int sceneNum)
    {
        SceneManager.LoadScene(sceneNum, LoadSceneMode.Additive);
        Stop();
       
    }

    

    public void DeleteScene(int sceneNum)
    {

        SceneManager.UnloadSceneAsync(sceneNumber);
    }

    public void SelectScene()
    {
        sceneNumber = Random.Range(3,5);
        //Debug.Log(sceneNumber);
        ShowScene(sceneNumber);
    }

    public void Stop()
    {
        Time.timeScale = 0f;
        stopMove = true;
    }
}
