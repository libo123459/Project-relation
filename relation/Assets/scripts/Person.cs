using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Person : MonoBehaviour {
    public string ClanTag = null;
	public UILabel text;
    public List<Person> Grand = new List<Person>();
    public List<Person> BroSis = new List<Person>();
    public List<Person> Parent = new List<Person>();
    public List<Person> Children = new List<Person>();
    public string lastname = null;
    public string firstname = null;
    public int sex = 0;
    public bool single = true;
    public int age = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
