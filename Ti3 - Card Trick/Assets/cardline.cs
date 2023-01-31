using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cardline : MonoBehaviour
{
    private string order = "A234567890";
    private string order1 = "2JA9K3Q4J258Q02750JKKA5248970J2J7490KAQ34802KQJ65460";
    // Start is called before the first frame update
    void Start()
    {
        plot2(order1.Substring(0,2));
        plot10(0,order1.Substring(2,10));
        plot10(1,order1.Substring(12,10));
        plot10(2,order1.Substring(22,10));
        plot10(3,order1.Substring(32,10));
        plot10(4,order1.Substring(42,10));
    }
    void plot2(string cards)
    {
        print(cards);
        GameObject sub_deck = new GameObject();
        sub_deck.transform.parent = this.transform;
        float constant = 82.50f;
        sub_deck.transform.parent = this.transform;
        sub_deck.AddComponent<LineRenderer>();
        LineRenderer line = sub_deck.GetComponent<LineRenderer>();
        line.positionCount = 2;
        line.SetWidth(0.003f,0.003f);
        line.material = new Material(Shader.Find("Sprites/Default"));
        Color lineColor = Color.white;
        line.SetColors(lineColor,lineColor);
        Vector3 offset = new Vector3(-0.02f,-0.04f,-0.04f);
        line.SetPosition(0,this.transform.position+offset+(cardPosition(cards.Substring(0,1))+new Vector3(0,0,0))/constant);
        line.SetPosition(1,this.transform.position+offset+(cardPosition(cards.Substring(1,1))+new Vector3(0,0,1))/constant);
    }
    void plot10(int position,string cards)
    {
        GameObject sub_deck = new GameObject();
        sub_deck.transform.parent = this.transform;
        string fS = cards.Substring(0,3);
        string sS = cards.Substring(3,3);
        string tS = cards.Substring(6,4);
        print(fS+":"+sS+":"+tS);
        float constant = 82.50f;
         
        GameObject first = new GameObject();
        GameObject second = new GameObject();
        GameObject third = new GameObject();
        first.transform.parent = sub_deck.transform;
        second.transform.parent = sub_deck.transform;
        third.transform.parent = sub_deck.transform;
        first.AddComponent<LineRenderer>();
        second.AddComponent<LineRenderer>();
        third.AddComponent<LineRenderer>();
        LineRenderer l1 = first.GetComponent<LineRenderer>();
        LineRenderer l2 = second.GetComponent<LineRenderer>();
        LineRenderer l3 = third.GetComponent<LineRenderer>();
        l1.positionCount = 3;
        l2.positionCount = 3;
        l3.positionCount = 4;
        l1.SetWidth(0.003f,0.003f);
        l2.SetWidth(0.003f,0.003f);
        l3.SetWidth(0.003f,0.003f);
        l1.material = new Material(Shader.Find("Sprites/Default"));
        l2.material = new Material(Shader.Find("Sprites/Default"));
        l3.material = new Material(Shader.Find("Sprites/Default"));
        Color lineColor = Color.white;
        if(position==0)
            lineColor = new Color(0.1f, 0.6f, 1.0f);
        if(position==1)
            lineColor = Color.green;
        if(position==2)
            lineColor = Color.yellow;
        if(position==3)
            lineColor = new Color(1, 0.3f, 0.1f);
        if(position==4)
            lineColor = Color.red;
        
        l1.SetColors(lineColor,lineColor);
        l2.SetColors(lineColor,lineColor);
        l3.SetColors(lineColor,lineColor);
        Vector3 offset = new Vector3(-0.02f,-0.04f,position/6.0f);
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
