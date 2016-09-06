using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class UImanage : MonoBehaviour {
	public social social;
	public Person person;
	public GameObject grid;
	public GameObject personBtn;
    public UILabel personInfo;
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
            thePerson.GetComponent<Person>().text.text = GetTheName(i);
			personList.Add(thePerson);
			grid.GetComponent<UIGrid> ().Reposition();
		}
	}

	public void OpenThePersonInfo(int personNum)
	{
        personInfo.text = GetTheName(personNum);
        for (int i = 0; i < social.Popu[personNum].Parent.Count; i++)
        {
            GameObject parent = Instantiate(personBtn);
            parent.transform.localScale = new Vector3(1,1,1);
           // parent.transform.SetParent();
        }
	}

    string GetTheName(int num)
    {
        string text = social.Popu[num].firstname + social.Popu[num].lastname;
        return text;
    }
    
}
