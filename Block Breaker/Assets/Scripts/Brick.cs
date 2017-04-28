using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

    private int timesHit;
    private bool isBreakable;
    private LevelManager levelManager;
    public Sprite[] hitSprites;
    public static int breakableCount = 0;
    public AudioClip crack; 
    void Start ()
    {
        timesHit = 0;
        isBreakable = this.tag == "Breakable";
        if (isBreakable)
        {
            breakableCount = breakableCount + 1; 
        }
        levelManager = GameObject.FindObjectOfType<LevelManager>();

	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (isBreakable)
        {
            AudioSource.PlayClipAtPoint(crack, transform.position);
            HandleHits();
        }
    }
    void HandleHits()
    {
        timesHit = timesHit + 1;
        int maxHits = hitSprites.Length + 1;
        if (timesHit == maxHits)
        {
            breakableCount = breakableCount - 1; 
            Destroy(gameObject);
        }
        else
        {
            LoadSprites();

        }
        if (breakableCount == 0)
        {
            WintheLevel(); 
        }
    }
    void WintheLevel()
    {
        levelManager.LoadNextLevel(); 
    }
    void LoadSprites()
    {
        int spriteIndex = timesHit - 1;
        if (hitSprites[spriteIndex])
        {
            this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
        }
    }
}
