using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

    private int timesHit;
    private LevelManager levelManager;
    public Sprite[] hitSprites;


	void Start ()
    {
        timesHit = 0;
        levelManager = GameObject.FindObjectOfType<LevelManager>();
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        bool isBreakable = this.tag == "Breakable";
        if (isBreakable)
        {
            HandleHits();
        }
    }
    void HandleHits()
    {
        timesHit = timesHit + 1;
        int maxHits = hitSprites.Length + 1;
        if (timesHit == maxHits)
        {
            Destroy(gameObject);
        }
        else
        {
            LoadSprites();

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
