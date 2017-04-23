using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class TextController : MonoBehaviour {
	public Text text; 
	private enum Status {Zelle, Spiegel, Zellenspiegel, Tuerschloss_auf, Tuerschloss_zu, Laken_1, Laken_2, Freiheit}
	private Status meinStatus; 
	// Use this for initialization
	void Start () 
	{
		text.text = "Spiel geladen, drücke Space um die Flucht zu starten!"; 
		meinStatus = Status.Zelle;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (meinStatus == Status.Zelle) {
			StatusZelle (); 
		} else if (meinStatus == Status.Laken_1) {
			StatusLaken1 ();
		} else if (meinStatus == Status.Tuerschloss_zu) {
			StatusTuerschlosszu (); 
		} else if (meinStatus == Status.Spiegel) {
			StatusSpiegel (); 
		} else if (meinStatus == Status.Zellenspiegel) {
			StatusZellenSpiegel (); 
		} else if (meinStatus == Status.Laken_2) {
			StatusLaken2 ();
		} else if (meinStatus == Status.Tuerschloss_auf) {
			StatusTuerschlossauf ();
		} else if (meinStatus == Status.Freiheit) {
			StatusFreiheit ();
		}
	}
	void StatusZelle()
	{
		text.text = "Du bist in einem Gefängnis, an der Wand hängt ein Spiegel " +
					"auf dem Bett liegt ein dreckiges Laken und an der Wand ist " + 
					"eine Tür. Diese ist von außen verschlossen.\n\n" +
					"Drücke L um das Laken zu betrachen!\n" +
					"Drücke S um den Spiegel zu betrachen!\n" +
					"Drücke T um das Türschloß zu betrachen!";
		if (Input.GetKeyDown (KeyCode.L)) 
		{
			meinStatus = Status.Laken_1;
		}
		else if (Input.GetKeyDown (KeyCode.T)) 
		{
			meinStatus = Status.Tuerschloss_zu;
		}
		else if (Input.GetKeyDown (KeyCode.S)) 
		{
			meinStatus = Status.Spiegel;
		}
	}
	void StatusLaken1()
	{
		text.text = "Diese Laken sind ekelhaft! \n\n" + 
					" Drücke R um zurück zu gelangen!";
		if (Input.GetKeyDown (KeyCode.R)) 
		{
			meinStatus = Status.Zelle;
		}
	}
	void StatusLaken2()
	{
		text.text = "Diese Laken sind noch immer ekelhaft! \n\n" + 
			" Drücke R um zurück zu gelangen!";
		if (Input.GetKeyDown (KeyCode.R)) 
		{
			meinStatus = Status.Zellenspiegel;
		}
	}
	void StatusTuerschlosszu()
	{
		text.text = "Diese Tür ist verschlossen! \n\n" + 
			" Drücke R um zurück zu gelangen!";
		if (Input.GetKeyDown (KeyCode.R)) 
		{
			meinStatus = Status.Zelle;
		}
	}
	void StatusTuerschlossauf()
	{
		text.text = "Diese Tür ist verschlossen!\n" +
					" aber der Schlüssel steckt!\n\n" + 
					" Drücke O um ihn zu drehen!";
		if (Input.GetKeyDown (KeyCode.O)) 
		{
			meinStatus = Status.Freiheit;
		}
	}
	void StatusSpiegel()
	{
		text.text = "Dieser Spiegel ist locker! \n\n" + 
			" Drücke N um den Spiegel zu nehmen!\n" +
			" Drücke R um zurück zu gelangen!";
		if (Input.GetKeyDown (KeyCode.R)) 
		{
			meinStatus = Status.Zelle;
		}
		else if (Input.GetKeyDown(KeyCode.N))
		{
			meinStatus = Status.Zellenspiegel;
			print("Spiegel genommen");
		}
	}
	void StatusZellenSpiegel()
	{
		text.text = "Du hast den Spiegel was machst du nun?\n\n" +
				"Drücke L um das Laken zu betrachen!\n" +
				"Drücke T um das Türschloß von aussen zu betrachen!";
		if (Input.GetKeyDown (KeyCode.L)) 
		{
			meinStatus = Status.Laken_2;
		}
		else if (Input.GetKeyDown (KeyCode.T)) 
		{
			meinStatus = Status.Tuerschloss_auf;
		}
		else if (Input.GetKeyDown (KeyCode.S)) 
		{
			meinStatus = Status.Spiegel;
		}
	}
	void StatusFreiheit()
	{
		text.text = "Du bist Frei! \n\n" +
			"Drücke B um die Flucht erneut zu starten!"; 
		if (Input.GetKeyDown (KeyCode.B))
		{
			meinStatus = Status.Zelle; 
		}
	}
}
