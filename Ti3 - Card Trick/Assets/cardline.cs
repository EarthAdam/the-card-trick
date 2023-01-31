using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cardline : MonoBehaviour
{
    public string order1 = "A234567890";
    public string order2 = "A234567890";
    public GameObject first;
    public GameObject second;
    public GameObject third;
    // Start is called before the first frame update
    void Start()
    {
        LineRenderer l1 = first.GetComponent<LineRenderer>();
        LineRenderer l2 = second.GetComponent<LineRenderer>();
        LineRenderer l3 = third.GetComponent<LineRenderer>();
        l1.positionCount = 3;
        l2.positionCount = 3;
        l3.positionCount = 4;
        string fS = order1.Substring(0,3);
        string sS = order1.Substring(3,3);
        string tS = order1.Substring(6,4);
        print(fS+":"+sS+":"+tS);
        float constant = 82.50f;
        Vector3 offset = new Vector3(-0.02f,-0.04f,0);
        l1.SetPosition(0,this.transform.position+offset+(cardPosition(fS.Substring(0,1))+new Vector3(0,0,0))/constant);
        l1.SetPosition(1,this.transform.position+offset+(cardPosition(fS.Substring(1,1))+new Vector3(0,0,1))/constant);
        l1.SetPosition(2,this.transform.position+offset+(cardPosition(fS.Substring(2,1))+new Vector3(0,0,2))/constant);
        l2.SetPosition(0,this.transform.position+offset+(cardPosition(sS.Substring(0,1))+new Vector3(0,0,4))/constant);
        l2.SetPosition(1,this.transform.position+offset+(cardPosition(sS.Substring(1,1))+new Vector3(0,0,5))/constant);
        l2.SetPosition(2,this.transform.position+offset+(cardPosition(sS.Substring(2,1))+new Vector3(0,0,6))/constant);
        l3.SetPosition(0,this.transform.position+offset+(cardPosition(tS.Substring(0,1))+new Vector3(0,0,8))/constant);
        l3.SetPosition(1,this.transform.position+offset+(cardPosition(tS.Substring(1,1))+new Vector3(0,0,9))/constant);
        l3.SetPosition(2,this.transform.position+offset+(cardPosition(tS.Substring(2,1))+new Vector3(0,0,10))/constant);
        l3.SetPosition(3,this.transform.position+offset+(cardPosition(tS.Substring(3,1))+new Vector3(0,0,11))/constant);

    }

    Vector3 cardPosition(string card_ID)
    {
        Vector3 position = new Vector3();
        if(card_ID=="A")
        {
            position = new Vector3(1,1,0);
        }
        if(card_ID=="2")
        {
            position = new Vector3(2,1,0);
        }
        if(card_ID=="3")
        {
            position = new Vector3(3,1,0);
        }
        if(card_ID=="4")
        {
            position = new Vector3(1,2,0);
        }
        if(card_ID=="5")
        {
            position = new Vector3(2,2,0);
        }
        if(card_ID=="6")
        {
            position = new Vector3(3,2,0);
        }
        if(card_ID=="7")
        {
            position = new Vector3(1,3,0);
        }
        if(card_ID=="8")
        {
            position = new Vector3(2,3,0);
        }
        if(card_ID=="9")
        {
            position = new Vector3(3,3,0);
        }
        if(card_ID=="0")
        {
            position = new Vector3(2,4,0);
        }
        if(card_ID=="J")
        {
            position = new Vector3(2,5,0);
        }
        if(card_ID=="Q")
        {
            position = new Vector3(3,6,0);
        }
        if(card_ID=="K")
        {
            position = new Vector3(1,6,0);
        }
        return position;
    }

}
