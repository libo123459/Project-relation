using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class UImanage : MonoBehaviour {
	public social social;
	public Person person;
	public GameObject grid;
	public GameObject personBtn;
    
	public List<GameObject> personList = new List<GameObject>();
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void	PutThePersonToList()
	{
		int Popu = social.Popu.Count;
		for(int i = 0; i < Popu; i++)
		{
			GameObject thePerson = Instantiate(personBtn);
			thePerson.transform.parent = grid.transform;
			thePerson.transform.localScale = new Vector3(1,1,1);
			thePerson.GetComponent<Person> ().text.text = social.Popu[i].firstname + social.Popu[i].lastname;
			personList.Add(thePerson);
			grid.GetComponent<UIGrid> ().Reposition();
		}
	}

	public void OpenThePersonInfo()
	{
		
	}
}
