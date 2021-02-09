using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class InfoCard
{

    public bool answer;
}

public class StoryManager : MonoBehaviour
{
    //기능만 넣을 것이나 테스트용으로 컨테이너도 넣어둠
    //나중에 따로 뺄 것
    private Dictionary<string, InfoCard> answers;
    public List<InfoCard> infoCards;
    private Dictionary<string, string> nouns;
    public List<string> words;
    private void Awake()
    {
        LoadWords(out nouns, "testfile");
        Debug.Log(nouns["1번"]);
    }
    private void Start()
    {
        //for (int i = 0; i < answers.Count; i++)
        //{
        //    infoCards[i] = new InfoCard();
        //}
    }



    public void LoadInfo(Dictionary<string,InfoCard> cardList, string fileName)
    {

    }
    public void LoadWords(out Dictionary<string, string> wordList, string fileName)
    {
        wordList = new Dictionary<string, string>();
        TextAsset file = Resources.Load(fileName) as TextAsset;
        StringBuilder s = new StringBuilder();
        s.Append(file.text);
        StringBuilder s1 = new StringBuilder(), s2 = new StringBuilder();

        while (s.Length >= 1)
        {
            int temp = 0;
            for (int i = 0; i < s.Length && ':' != s[i]; i++, temp = i)
            {
                s1.Append(s[i]);
            }
            s.Remove(0, temp + 1);
            temp = 0;

            for (int i = 0; i < s.Length && '\n' != s[i]; i++, temp = i)
            {
                s2.Append(s[i]);
            }
            s.Remove(0, temp);

            string temp1 = s1.ToString();
            string temp2 = s2.ToString();
            wordList.Add(temp1, temp2);
            Debug.Log(string.Format("{0}, {1}, {2}", temp1, temp2, wordList[temp1]));
            s1.Clear();
            s2.Clear();
        }
    }
    public void GetWords(string word, Dictionary<string, string> dic, List<string> list)
    {
        if(list.Contains(word) || dic.ContainsKey(word))
        {
            return;
        }
        else
        {
            list.Add(word);
        }
    }
}
