using GoogleMobileAds.Api;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour {

    private BannerView bannerView;
    public AudioClip audio_bird;
    public AudioClip audio_coin;
    public float repawndealy;
    private PlayControler gameplayer;
    int coinScore = 0;
    AudioSource audiosource;
    public Text text;
    // Use this for initialization
    void Start () {
      
        gameplayer = FindObjectOfType<PlayControler>();
        audiosource = GetComponent<AudioSource>();
    

    }
 
    // Update is called once per frame
    void Update () {
		
	}

    public void Respaws()
    {
        StartCoroutine("callFuncation");
      
    }

    public IEnumerator callFuncation()
    {
        yield return new WaitForSeconds(2);
        gameplayer.gameObject.SetActive(false);
        gameplayer.transform.position = gameplayer.last_checkpoint;
        gameplayer.gameObject.SetActive(true);
        gameplayer.isToochGround = true;
    }

    public void addCoinScore(int coinvalue)
    {
        audiosource.clip = audio_coin;
        audiosource.Play();

        coinScore += coinvalue;

       

        text.text =""+ coinScore;
      //  Debug.Log("test" + coinvalue);
    }
    public void addBombScore(int coinvalue)
    {
        audiosource.clip = audio_coin;
        audiosource.Play();
       
        coinScore += coinvalue;
        text.text = "" + coinScore;
        Debug.Log("test" + coinvalue);
    }
    public void scoreDonw()
    {
        audiosource.clip = audio_bird;
        audiosource.Play();

        coinScore = coinScore - 5;
        text.text = "" + coinScore;
      //  Debug.Log("test" + coinvalue);
    }

}