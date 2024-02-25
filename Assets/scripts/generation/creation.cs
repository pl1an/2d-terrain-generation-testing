using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creation : MonoBehaviour
{
    public GameObject adao;
    public GameObject pref;
    public end end;

    [Space]
    public GameObject temp;
    public string parentpos;
    public string direction_name;

    [Space]
    public bool right = true;
    public bool left = true;
    public bool up = true;
    public bool down = true;

    [Space]
    public float offset;

    [Space]
    public int prob1;
    public int prob2;
    public int choice;
    public int number;
    public int ncreat = 0;

    [Space]
    public int up_probability;
    public int down_probability;
    public int right_probability;
    public int left_probability;

    // Start is called before the first frame update
    void Start()
    {
        choice = Random.Range(1, 101);

        ncreat = 0;
        right = true;
        up = true;
        down = true;
        left = true;

        if(choice <= prob1)
        {
            number = 1;
        }
        else if(choice <= prob2)
        {
            number = 2;
        }
        else
        {
            number = 3;
        }

        end = GameObject.Find("map_manager").GetComponent<Transform>().Find(direction_name).GetComponent<end>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Random.Range(1, 101) <= up_probability && this.gameObject.GetComponent<creation>().parentpos != "up" && end.continue_gen && ncreat < number && up)
        {
            ncreat = ncreat + 1;
            end.gen = end.gen + 1;
            temp = Instantiate(pref);
            temp.GetComponent<Transform>().SetPositionAndRotation(new Vector3(temp.GetComponent<Transform>().Find("up").GetComponent<Transform>().position.x, temp.GetComponent<Transform>().Find("up").GetComponent<Transform>().position.y + offset, temp.GetComponent<Transform>().Find("up").GetComponent<Transform>().position.z), temp.GetComponent<Transform>().rotation);
            temp.GetComponent<creation>().parentpos = "down";
            up = false;
        }
        if (Random.Range(1, 101) <= down_probability && this.gameObject.GetComponent<creation>().parentpos != "down" && end.continue_gen && ncreat < number && down)
        {
            ncreat = ncreat + 1;
            end.gen = end.gen + 1;
            temp = Instantiate(pref);
            temp.GetComponent<Transform>().SetPositionAndRotation(new Vector3(temp.GetComponent<Transform>().Find("down").GetComponent<Transform>().position.x, temp.GetComponent<Transform>().Find("down").GetComponent<Transform>().position.y - offset, temp.GetComponent<Transform>().Find("down").GetComponent<Transform>().position.z), temp.GetComponent<Transform>().rotation);
            temp.GetComponent<creation>().parentpos = "up";
            down = false;
        }
        if (Random.Range(1, 101) <= right_probability && this.gameObject.GetComponent<creation>().parentpos != "right" && end.continue_gen && ncreat < number && right)
        {
            ncreat = ncreat + 1;
            end.gen = end.gen + 1;
            temp = Instantiate(pref);
            temp.GetComponent<Transform>().SetPositionAndRotation(new Vector3(temp.GetComponent<Transform>().Find("right").GetComponent<Transform>().position.x + offset, temp.GetComponent<Transform>().Find("right").GetComponent<Transform>().position.y, temp.GetComponent<Transform>().Find("right").GetComponent<Transform>().position.z), temp.GetComponent<Transform>().rotation);
            temp.GetComponent<creation>().parentpos = "left";
            right = false;
        }
        if (Random.Range(1, 101) <= left_probability && this.gameObject.GetComponent<creation>().parentpos != "left" && end.continue_gen && ncreat < number && left)
        {
            ncreat = ncreat + 1;
            end.gen = end.gen + 1;
            temp = Instantiate(pref);
            temp.GetComponent<Transform>().SetPositionAndRotation(new Vector3(temp.GetComponent<Transform>().Find("left").GetComponent<Transform>().position.x - offset, temp.GetComponent<Transform>().Find("left").GetComponent<Transform>().position.y, temp.GetComponent<Transform>().Find("left").GetComponent<Transform>().position.z), temp.GetComponent<Transform>().rotation);
            temp.GetComponent<creation>().parentpos = "right";
            left = false;
        }
    }
}
