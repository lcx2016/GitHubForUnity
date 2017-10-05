using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
    IEnumerator Start()
    {
        TestFun();
        //Fun();
        yield return null;
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    void TestFun() 
    {
        List<Vector2> listPos = new List<Vector2>();
        for (int i = 0; i < 8; i++)
        {
            listPos.Add(new Vector2(i, i));
        }
        int j = 0;
        foreach (Vector2 pos in listPos)
        {
            int index = Random.Range(0, listPos.Count);
            Vector2 mewPos = listPos[index];
            print(j);
            j++;
            //listPos.RemoveAt(index);  不能在循环里面做删除List元素
            //listPos.Remove(pos);
        }
    }

    void Fun() 
    {
        string s = "10";
        char zero = '0';
        print("Before destroy " + (s[1] - zero));
        Destroy(gameObject); //尽量把Destroy 游戏物体的方法放到最后执行。

        for (int i = 0; i < 3; i++)
        {
            print(i);
        }

        print("After destroy");
        StartCoroutine(IEFun());
    }

    IEnumerator IEFun() 
    {
        print("In the IEFun()"); 
        yield return null;
        //yield return new WaitForSeconds(1f);
        print("IEFun() end");  //在调用Destroy之后，脚本函数还是会执行一会儿，但这个协程函数不会被执行完
    }
}
