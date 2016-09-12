using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class UImanage : MonoBehaviour {
	public social social;
	public Person person;
	public GameObject grid;
	public GameObject GrandGrid;
	public GameObject ParentGrid;
	public GameObject BroSisGrid;
	public GameObject ChildrenGrid;
	public GameObject personBtn;
    public UILabel personInfo;

	// Use this for initialization
	void Start () 
	{
		person.uimanage = this;
	
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
           // thePerson.GetComponent<Person>().text.text = GetTheName(i);
			thePerson.GetComponent<Person>().PersonNum = i;
			grid.GetComponent<UIGrid> ().Reposition();
		}
	}

	public void OpenThePersonInfo(int personNum)
	{
		
		//personInfo.text = GetTheName(personNum);
		for (int i = 0; i < social.Popu[personNum].Grand.Count; i++)
		{
			if(social.Popu[personNum].Grand[i] != null)
			{
				GameObject Grand = Instantiate(personBtn);
                Grand.transform.SetParent(GrandGrid.transform);
                Grand.transform.localScale = new Vector3(1,1,1);
				
			}

		}
		for (int i = 0; i < social.Popu[personNum].Parent.Count; i++)
        {
			if(social.Popu[personNum].Parent[i] != null)
			{
				GameObject parent = Instantiate(personBtn);
                parent.transform.SetParent(ParentGrid.transform);
                parent.transform.localScale = new Vector3(1,1,1);
				
			}
		}
		for (int i = 0; i < social.Popu[personNum].BroSis.Count; i++)
		{
			if(social.Popu[personNum].BroSis[i] != null)
			{
				Person BroSis = Instantiate(social.Popu[personNum].BroSis[i] );
                BroSis.transform.SetParent(BroSisGrid.transform);
                BroSis.transform.localScale = new Vector3(1,1,1);
	
			}

		}
		for (int i = 0; i < social.Popu[personNum].Children.Count; i++)
		{
			if(social.Popu[personNum].Children[i] != null)
			{
				GameObject Children = Instantiate(personBtn);
                Children.transform.SetParent(ChildrenGrid.transform);
                Children.transform.localScale = new Vector3(1,1,1);
				
			}

		}

	}

    

    
}
