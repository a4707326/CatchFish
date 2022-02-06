using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{

    public GameObject[] Maps;
    public AudioClip[] AudioClips;
    public GameObject parent;
    public AudioSource AudioSource;
    private float changeTime = 20.0f;
    private float volume =0.1f;
    private GameObject currentMap;
    private int mapsIndex = -1;
    private int audioIndex = -1;
    //private AudioClip currentAudio;

    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("ChangeMap",0f, changeTime);
        InvokeRepeating("ChangeAudio", 0f, changeTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeMap()
    {

        if (currentMap != null)
        {
            Destroy(currentMap);
        }
        //int index = Random.Range(0, Maps.Length);
        mapsIndex = mapsIndex + 1 < Maps.Length ? mapsIndex + 1 : 0;
        currentMap = GameObject.Instantiate(Maps[mapsIndex], parent.transform);
    }

    public void ChangeAudio()
    {
        //int index Random.InitState(AudioClips.Length);
        audioIndex = audioIndex + 1 < AudioClips.Length ? audioIndex + 1 : 0;

        int index = Random.Range(0, AudioClips.Length);
        AudioSource.clip = AudioClips[index];
        AudioSource.volume = volume;
        AudioSource.Play();
        //AudioSource.PlayClipAtPoint(AudioClips[index],transform.position);
        

    }
}
