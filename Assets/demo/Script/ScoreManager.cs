using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField]
    private TMP_Text m_TextMeshPro;
    private static int Score;
    void Start()
    {
        Score = 0;
    }

    private void Update()
    {
        m_TextMeshPro.text = Score.ToString();
    }

    public void AddScore(int ponits)
    {
        Score = Score + ponits;
    }

    public void RemoveScore(int ponits)
    {
        Score = Score - ponits;
    }
}
